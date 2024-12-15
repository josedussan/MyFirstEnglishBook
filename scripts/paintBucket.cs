using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class paintBucket : MonoBehaviour
{
  public int colorCount;
  //public SpriteRenderer piel,escamas,circulos,pecho;
  public Image piel, escamas, circulos, pecho;
  public Text txtingles, txtespanol;
  public GameObject cuadro;
  public AudioSource asource;
  public List<AudioClip> audios;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    
    }

  public void paint(int colorcode)
  {
    asource.PlayOneShot(audios[colorcode]);
    switch (colorcode)
    {
      case 0:
        piel.DOColor(new Color(0.93f, 0.11f, 0.14f, 1), 0.4f);
        escamas.DOColor(new Color(0.64f, 0.04f, 0.06f, 1),0.4f);
        circulos.DOColor(new Color(0.99f, 0.52f, 0.33f, 1),0.4f);
        pecho.DOColor(new Color(0.99f, 0.30f, 0.33f, 1),0.4f);
        cambiarTexto("red","rojo", new Color(0.93f, 0.11f, 0.14f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 1:
        piel.DOColor(new Color(1,0.95f,0, 1), 0.4f);
        escamas.DOColor(new Color(0.73f,0.70f,0.03f, 1), 0.4f);
        circulos.DOColor(new Color(0.99f,0.96f,0.37f, 1), 0.4f);
        pecho.DOColor(new Color(0.99f,0.99f,0.37f, 1), 0.4f);
        cambiarTexto("yellow", "amarillo", new Color(1, 0.95f, 0, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 2:
        piel.DOColor(new Color(0.96f,0.51f,0.12f, 1), 0.4f);
        escamas.DOColor(new Color(0.76f,0.36f,0.02f, 1), 0.4f);
        circulos.DOColor(new Color(0.97f,0.67f,0.41f, 1), 0.4f);
        pecho.DOColor(new Color(0.76f,0.63f,0.02f, 1), 0.4f);
        cambiarTexto("orange", "naranja", new Color(0.96f, 0.51f, 0.12f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 3:
        piel.DOColor(new Color(0,0.65f,0.31f, 1), 0.4f);
        escamas.DOColor(new Color(0,0.39f,0.19f, 1), 0.4f);
        circulos.DOColor(new Color(0.39f,0.98f,0.68f, 1), 0.4f);
        pecho.DOColor(new Color(0.39f, 0.98f, 0.41f, 1), 0.4f);
        cambiarTexto("green", "verde", new Color(0, 0.65f, 0.31f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 4:
        piel.DOColor(new Color(0.97f, 0.67f, 0.67f, 1), 0.4f);
        escamas.DOColor(new Color(0.85f, 0.35f, 0.35f, 1), 0.4f);
        circulos.DOColor(new Color(0.97f, 0.74f, 0.75f, 1), 0.4f);
        pecho.DOColor(new Color(0.97f, 0.86f, 0.75f, 1), 0.4f);
        cambiarTexto("pink", "rosado", new Color(0.97f, 0.67f, 0.67f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 5:
        piel.DOColor(new Color(0, 0.68f, 0.93f, 1), 0.4f);
        escamas.DOColor(new Color(0, 0.43f, 0.59f, 1), 0.4f);
        circulos.DOColor(new Color(0.55f, 0.86f, 0.98f, 1), 0.4f);
        pecho.DOColor(new Color(0.55f, 0.86f, 0.71f, 1), 0.4f);
        cambiarTexto("blue", "azul", new Color(0, 0.68f, 0.93f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 6:
        piel.DOColor(new Color(0.50f, 0.41f, 0.39f, 1), 0.4f);
        escamas.DOColor(new Color(0.36f, 0.20f, 0.15f, 1), 0.4f);
        circulos.DOColor(new Color(0.80f, 0.57f, 0.50f, 1), 0.4f);
        pecho.DOColor(new Color(0.80f, 0.70f, 0.50f, 1), 0.4f);
        cambiarTexto("brown", "marrón", new Color(0.50f, 0.41f, 0.39f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 7:
        piel.DOColor(new Color(0.55f, 0.40f, 0.68f, 1), 0.4f);
        escamas.DOColor(new Color(0.30f, 0.19f, 0.39f, 1), 0.4f);
        circulos.DOColor(new Color(0.76f, 0.47f, 0.91f, 1), 0.4f);
        pecho.DOColor(new Color(0.76f, 0.68f, 0.91f, 1), 0.4f);
        cambiarTexto("purple", "morado", new Color(0.55f, 0.40f, 0.68f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 8:
        piel.DOColor(new Color(0.13f, 0.12f, 0.12f, 1), 0.4f);
        escamas.DOColor(new Color(0, 0, 0, 1), 0.4f);
        circulos.DOColor(new Color(0.24f, 0.24f, 0.24f, 1), 0.4f);
        pecho.DOColor(new Color(0.24f, 0.31f, 0.24f, 1), 0.4f);
        cambiarTexto("black", "negro", new Color(0.13f, 0.12f, 0.12f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 9:
        piel.DOColor(new Color(1, 1, 1, 1), 0.4f);
        escamas.DOColor(new Color(1, 1, 1, 1), 0.4f);
        circulos.DOColor(new Color(1, 1, 1, 1), 0.4f);
        pecho.DOColor(new Color(1, 1, 1, 1), 0.4f);
        cambiarTexto("white", "blanco", new Color(0.80f, 0.89f, 0.89f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 10:
        piel.DOColor(new Color(0.65f, 0.66f, 0.67f, 1), 0.4f);
        escamas.DOColor(new Color(0.47f, 0.47f, 0.48f, 1), 0.4f);
        circulos.DOColor(new Color(0.87f, 0.87f, 0.87f, 1), 0.4f);
        pecho.DOColor(new Color(0.87f, 0.87f, 0.76f, 1), 0.4f);
        cambiarTexto("grey", "gris", new Color(0.65f, 0.66f, 0.67f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 11:
        piel.DOColor(new Color(0.90f, 0.73f, 0.27f, 1), 0.4f);
        escamas.DOColor(new Color(0.76f, 0.62f, 0.21f, 1), 0.4f);
        circulos.DOColor(new Color(1, 0.85f, 0.45f, 1), 0.4f);
        pecho.DOColor(new Color(1, 0.95f, 0.45f, 1), 0.4f);
        cambiarTexto("gold", "dorado", new Color(0.90f, 0.73f, 0.27f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 12:
        piel.DOColor(new Color(0.98f, 0.82f, 0.75f, 1), 0.4f);
        escamas.DOColor(new Color(0.80f, 0.52f, 0.64f, 1), 0.4f);
        circulos.DOColor(new Color(0.98f, 0.85f, 0.80f, 1), 0.4f);
        pecho.DOColor(new Color(0.98f, 0.85f, 0.61f, 1), 0.4f);
        cambiarTexto("skin", "piel", new Color(0.98f, 0.82f, 0.75f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
      case 13:
        piel.DOColor(new Color(0.81f, 0.82f, 0.83f, 1), 0.4f);
        escamas.DOColor(new Color(0.66f, 0.66f, 0.66f, 1), 0.4f);
        circulos.DOColor(new Color(0.94f, 0.94f, 0.94f, 1), 0.4f);
        pecho.DOColor(new Color(0.94f, 0.94f, 0.85f, 1), 0.4f);
        cambiarTexto("silver", "plateado", new Color(0.81f, 0.82f, 0.83f, 1));
        cuadro.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
        cuadro.transform.DOScale(new Vector3(0, 0, 0), 0.25f).SetDelay(1);
        break;
    }
    
  }

  public void cambiarTexto(string ingles,string espanol,Color colortex)
  {
    txtespanol.color = colortex;
    txtingles.color = colortex;
    txtespanol.text = espanol.ToLower();
    txtingles.text = ingles.ToUpper();
  }
}
