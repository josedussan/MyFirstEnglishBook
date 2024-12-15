using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class mensajeFlotante : MonoBehaviour
{
  public Text txtingles, txtespanol,txtpronunciacion;
  public GameObject panel;
  public AudioSource asource;
  public List<AudioClip> audios;
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
    switch (objeto)
    {
      case 0:
        txtingles.text = "PENCIL";
        txtespanol.text = "Lápiz";
        txtpronunciacion.text = "(pensol)";
        break;
      case 1:
        txtingles.text = "PEN";
        txtespanol.text = "Lapicero";
        txtpronunciacion.text = "(pen)";
        break;
      case 2:
        txtingles.text = "ERASER";
        txtespanol.text = "Borrador";
        txtpronunciacion.text = "(iréiser)";
        break;
      case 3:
        txtingles.text = "BOOK";
        txtespanol.text = "Libro";
        txtpronunciacion.text = "(buk)";
        break;
      case 4:
        txtingles.text = "NOTE BOOK";
        txtespanol.text = "Cuaderno";
        txtpronunciacion.text = "(nóutbuk)";
        break;
      case 5:
        txtingles.text = "PENCIL CASE";
        txtespanol.text = "Cartuchera";
        txtpronunciacion.text = "(pensol kéis)";
        break;
      case 6:
        txtingles.text = "SHARPENER";
        txtespanol.text = "Sacapunta";
        txtpronunciacion.text = "(shárpener)";
        break;
      case 7:
        txtingles.text = "RULER";
        txtespanol.text = "Regla";
        txtpronunciacion.text = "(rúler)";
        break;
      case 8:
        txtingles.text = "GLUE";
        txtespanol.text = "Pegamento";
        txtpronunciacion.text = "(glu)";
        break;
      case 9:
        txtingles.text = "SCHOOL BAG";
        txtespanol.text = "Bolso escolar";
        txtpronunciacion.text = "(escul bag)";
        break;
      case 10:
        txtingles.text = "SCISSORS";
        txtespanol.text = "Tijeras";
        txtpronunciacion.text = "(sisors)";
        break;
      case 11:
        txtingles.text = "COLORS";
        txtespanol.text = "Colores";
        txtpronunciacion.text = "(colors)";
        break;
    }
    panel.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
  }

  public void cerrarPanel() {
    panel.transform.DOScale(new Vector3(0, 0, 0), 0.25f);
  }

  public void activarAudio()
  {
    asource.PlayOneShot(audios[numeroaudio]);
  }
}
