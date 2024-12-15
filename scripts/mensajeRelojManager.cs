using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class mensajeRelojManager : MonoBehaviour
{
  // Start is called before the first frame update
  public GameObject mensaje, panelLetras;
  public AudioSource asource;
  public Text ingles, pronum, espa;
  public List<AudioClip> sonidos;
  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void CambiarTexto(string ingl, string pro, string esp)
  {
    ingles.text = ingl;
    pronum.text = pro;
    espa.text = esp;
  }
  public void cambiar(int id)
  {
    asource.PlayOneShot(sonidos[id]);
    switch (id)
    {
      case 0:
        CambiarTexto("Seconds", "(sekunds)", "Segundos");
        
        break;
      case 1:
        CambiarTexto("Minutes", "(minits)", "Minutos");
        break;
      case 2:
        CambiarTexto("Hands", "(jands)", "Manecillas");
        break;
      case 3:
        CambiarTexto("Hour", "(aur)", "Horas");
        break;
      case 4:
        CambiarTexto("Numbers", "(nambers)", "Numeros");
        break;
    }
    panelLetras.transform.DOScale(new Vector2(1, 1), 0.1f);
    panelLetras.transform.DOScale(new Vector2(0, 0), 0.1f).SetDelay(2);
  }
}
