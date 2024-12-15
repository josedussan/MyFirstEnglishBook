using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class QuizManagerLetras : MonoBehaviour
{
  public static QuizManagerLetras instance; //Instance to make is available in other scripts without reference


  [SerializeField] private GameObject gameComplete,correctMessage;


  //Scriptable data which store our questions data Datos programables que almacenan los datos de nuestras preguntas.
  [SerializeField] private QuizDataScriptable questionDataScriptable;
  [SerializeField] private Image questionImage,correctImage;           //image element to show the image elemento de imagen para mostrar la imagen
  [SerializeField] private WordData[] answerWordList;     //list of answers word in the game lista de preguntas
  [SerializeField] private WordData[] optionsWordList;    //list of options word in the game lista de opciones
 public List<Sprite> correctImages;
  [SerializeField] private AudioSource asource;
  [SerializeField] private AudioClip soundcorrect;


  private GameStatus gameStatus = GameStatus.Playing;     //to keep track of game status para realizar un seguimiento del estado del juego
  private char[] wordsArray = new char[14];               //array which store char of each options

  private List<int> selectedWordsIndex;                   //list which keep track of option word index w.r.t answer word index
  private int currentAnswerIndex = 0, currentQuestionIndex = 0;   //index to keep track of current answer and current question
                                                                  //índice para realizar un seguimiento de la respuesta actual y la pregunta actual
  private bool correctAnswer = true;                      //bool to decide if answer is correct or not bool para decidir si la respuesta es correcta o no
  private string answerWord;                              //string to store answer of current question cadena para almacenar la respuesta de la pregunta actual

  private void Awake()
  {
    if (instance == null)
      instance = this;
    else
      Destroy(this.gameObject);
  }

  // Start is called before the first frame update
  void Start()
  {
    selectedWordsIndex = new List<int>();           //create a new list at start
    SetQuestion();                                  //set question
  }

  void SetQuestion()
  {
    gameStatus = GameStatus.Playing;                //set GameStatus to playing 

    //set the answerWord string variable establecer la variable de cadena respuestaPalabra
    answerWord = questionDataScriptable.questions[currentQuestionIndex].answer;
    //set the image of question
    questionImage.sprite = questionDataScriptable.questions[currentQuestionIndex].questionImage;

    ResetQuestion();                               //reset the answers and options value to orignal     

    selectedWordsIndex.Clear();                     //clear the list for new question
    Array.Clear(wordsArray, 0, wordsArray.Length);  //clear the array

    //add the correct char to the wordsArray
    for (int i = 0; i < answerWord.Length; i++)
    {
      wordsArray[i] = char.ToUpper(answerWord[i]);
    }

    //add the dummy char to wordsArray
    for (int j = answerWord.Length; j < wordsArray.Length; j++)
    {
      wordsArray[j] = (char)UnityEngine.Random.Range(65, 90);
    }

    wordsArray = ShuffleList.ShuffleListItems<char>(wordsArray.ToList()).ToArray(); //Randomly Shuffle the words array

    //set the options words Text value
    for (int k = 0; k < optionsWordList.Length; k++)
    {
      optionsWordList[k].SetWord(wordsArray[k]);
    }

  }

  //Method called on Reset Button click and on new question
  public void ResetQuestion()
  {
    //activate all the answerWordList gameobject and set their word to "_"
    for (int i = 0; i < answerWordList.Length; i++)
    {
      answerWordList[i].gameObject.SetActive(true);
      answerWordList[i].SetWord('_');
    }

    //Now deactivate the unwanted answerWordList gameobject (object more than answer string length)
    for (int i = answerWord.Length; i < answerWordList.Length; i++)
    {
      answerWordList[i].gameObject.SetActive(false);
    }

    //activate all the optionsWordList objects
    for (int i = 0; i < optionsWordList.Length; i++)
    {
      optionsWordList[i].gameObject.SetActive(true);
    }

    currentAnswerIndex = 0;
  }

  /// <summary>
  /// When we click on any options button this method is called
  /// </summary>
  /// <param name="value"></param>
  public void SelectedOption(WordData value)
  {
    //if gameStatus is next or currentAnswerIndex is more or equal to answerWord length
    if (gameStatus == GameStatus.Next || currentAnswerIndex >= answerWord.Length) return;

    selectedWordsIndex.Add(value.transform.GetSiblingIndex()); //add the child index to selectedWordsIndex list
    value.gameObject.SetActive(false); //deactivate options object
    answerWordList[currentAnswerIndex].SetWord(value.wordValue); //set the answer word list

    currentAnswerIndex++;   //increase currentAnswerIndex

    //if currentAnswerIndex is equal to answerWord length
    if (currentAnswerIndex == answerWord.Length)
    {
      correctAnswer = true;   //default value
                              //loop through answerWordList
      for (int i = 0; i < answerWord.Length; i++)
      {
        //if answerWord[i] is not same as answerWordList[i].wordValue
        if (char.ToUpper(answerWord[i]) != char.ToUpper(answerWordList[i].wordValue))
        {
          correctAnswer = false; //set it false
          break; //and break from the loop
        }
      }

      //if correctAnswer is true
      if (correctAnswer)
      {
        Debug.Log("Correct Answer");//aqui
        correctImage.sprite = correctImages[UnityEngine.Random.Range(0,correctImages.Count)];
        correctMessage.transform.DOScale(new Vector2(1, 1), 0.2f);
        correctMessage.transform.DOScale(Vector2.zero, 0.2f).SetDelay(0.6f).SetEase(Ease.InOutElastic);
        asource.PlayOneShot(soundcorrect);
        gameStatus = GameStatus.Next; //set the game status
        currentQuestionIndex++; //increase currentQuestionIndex

        //if currentQuestionIndex is less that total available questions
        if (currentQuestionIndex < questionDataScriptable.questions.Count)
        {
          Invoke("SetQuestion", 0.5f); //go to next question
        }
        else
        {
          Debug.Log("Game Complete"); //else game is complete
          gameComplete.SetActive(true);
        }
      }
    }
  }

  public void ResetLastWord()
  {
    if (selectedWordsIndex.Count > 0)
    {
      int index = selectedWordsIndex[selectedWordsIndex.Count - 1];
      optionsWordList[index].gameObject.SetActive(true);
      selectedWordsIndex.RemoveAt(selectedWordsIndex.Count - 1);

      currentAnswerIndex--;
      answerWordList[currentAnswerIndex].SetWord('_');
    }
  }

  public void reiniciarJuego() {
    currentAnswerIndex = 0; currentQuestionIndex = 0;   
    correctAnswer = true;
    gameStatus = GameStatus.Playing;
    gameComplete.SetActive(false);
    SetQuestion();
    
  }

}

[System.Serializable]
public class QuestionData
{
  public Sprite questionImage;
  public string answer;
}

public enum GameStatus
{
  Next,
  Playing
}
