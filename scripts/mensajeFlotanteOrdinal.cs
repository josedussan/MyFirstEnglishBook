using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class mensajeFlotanteOrdinal : MonoBehaviour
{
  public Text txtingles, txtespanol, txtpronunciacion;
  public GameObject panel;
  public List<AudioClip> audios;
  public AudioSource asource;
  private int numeroaudio;
  // Start is called before the first frame update
  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void mostrarPanel(int objeto)
  {
    numeroaudio = objeto;
    Debug.Log(numeroaudio);
    switch (objeto)
    {
      case 0:
        txtingles.text = "FIRST";
        txtespanol.text = "Primero";
        txtpronunciacion.text = "(férs)";
        
        break;
      case 1:
        txtingles.text = "SECOND";
        txtespanol.text = "Segundo";
        txtpronunciacion.text = "(sékond)";
        break;
      case 2:
        txtingles.text = "THIRD";
        txtespanol.text = "Tercero";
        txtpronunciacion.text = "(zérd)";
        break;
      case 3:
        txtingles.text = "FOURTH";
        txtespanol.text = "Cuarto";
        txtpronunciacion.text = "(fóorz)";
        break;
      case 4:
        txtingles.text = "FIFTH";
        txtespanol.text = "Quinto";
        txtpronunciacion.text = "(fifz)";
        break;
      case 5:
        txtingles.text = "SIXTH";
        txtespanol.text = "Sexto";
        txtpronunciacion.text = "(sixz)";
        break;
      case 6:
        txtingles.text = "SEVENTH";
        txtespanol.text = "Séptimo";
        txtpronunciacion.text = "(sévenz)";
        break;
      case 7:
        txtingles.text = "EIGHTH";
        txtespanol.text = "Octavo";
        txtpronunciacion.text = "(éitz)";
        break;
      case 8:
        txtingles.text = "NINTH";
        txtespanol.text = "Noveno";
        txtpronunciacion.text = "(náinz)";
        break;
      case 9:
        txtingles.text = "TENTH";
        txtespanol.text = "Décimo";
        txtpronunciacion.text = "(ténz)";
        break;
    }
    panel.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
  }

  public void cerrarPanel()
  {
    panel.transform.DOScale(new Vector3(0, 0, 0), 0.25f);
  }

  public void activarAudio()
  {
      asource.PlayOneShot(audios[numeroaudio]);
  }
}
