using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class mensajeFlotanteImagen : MonoBehaviour
{
  public Text txtespanol, txtpronunciacion;
  public GameObject panel;
  public List<Sprite> imagenes = new List<Sprite>();
  public Image imagen;
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
    switch (objeto)
    {
      case 0:
        txtespanol.text = "Enero";
        txtpronunciacion.text = "(yanueri)";
        imagen.sprite=imagenes[0];
        break;
      case 1:
        txtespanol.text = "Febrero";
        txtpronunciacion.text = "(februeri)";
        imagen.sprite = imagenes[1];
        break;
      case 2:
        txtespanol.text = "Marzo";
        txtpronunciacion.text = "(march)";
        imagen.sprite = imagenes[2];
        break;
      case 3:
        txtespanol.text = "Abril";
        txtpronunciacion.text = "(eiprol)";
        imagen.sprite = imagenes[3];
        break;
      case 4:
        txtespanol.text = "Mayo";
        txtpronunciacion.text = "(mei)";
        imagen.sprite = imagenes[4];
        break;
      case 5:
        txtespanol.text = "Junio";
        txtpronunciacion.text = "(yun)";
        imagen.sprite = imagenes[5];
        break;
      case 6:
        txtespanol.text = "Julio";
        txtpronunciacion.text = "(yulai)";
        imagen.sprite = imagenes[0];
        break;
      case 7:
        txtespanol.text = "Agosto";
        txtpronunciacion.text = "(o-gost)";
        imagen.sprite = imagenes[1];
        break;
      
      case 8:
        txtespanol.text = "Septiembre";
        txtpronunciacion.text = "(september)";
        imagen.sprite = imagenes[2];
        break;
      case 9:
        txtespanol.text = "Octubre";
        txtpronunciacion.text = "(octouber)";
        imagen.sprite = imagenes[3];
        break;
      case 10:
        txtespanol.text = "Noviembre";
        txtpronunciacion.text = "(nouvember)";
        imagen.sprite = imagenes[4];
        break;
      case 11:
        txtespanol.text = "Diciembre";
        txtpronunciacion.text = "(disember)";
        imagen.sprite = imagenes[5];
        break;
    }
    panel.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
    panel.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1.5f);
  }

}

