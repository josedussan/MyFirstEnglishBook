using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class emotionsManager : MonoBehaviour
{
  public List<GameObject> emociones;
  public GameObject mensaje,gif,panelLetras;
  public AudioSource asource;
  public Text ingles, pronum, espa;
  public List<AudioClip> sonidos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void cambiar(int id)
  {
    //asource.PlayOneShot(sonidos[id]);
    desactivarEmociones();
    gif.SetActive(true);
    Invoke("desactivarPoof", 0.4f);
    emociones[id].transform.DOScale(new Vector2(1, 1), 0.2f);
    switch (id)
    {
      case 6:
        CambiarTexto("Scared", "(eskerd)", "Asustado");
        break;
      case 1:
        CambiarTexto("Sad", "(sad)", "Triste");
        break;
      case 2:
        CambiarTexto("Happy", "(jápi)", "Feliz");
        break;
      case 3:
        CambiarTexto("Hungry", "(jungri)", "Hambriento");
        break;
      case 4:
        CambiarTexto("Angry", "(engri)", "Molesto");
        break;
      case 5:
        CambiarTexto("Surprise", "(sorpráis)", "Sorprendido");
        break;
    }
    panelLetras.transform.DOScale(new Vector2(1, 1), 0.1f);
    panelLetras.transform.DOScale(new Vector2(0, 0), 0.1f).SetDelay(2);
  }

  public void desactivarPoof() {
    gif.SetActive(false);
  }
  public void desactivarEmociones() {
    for (int i = 1; i < 7; i++) {
      emociones[i].transform.DOScale(new Vector2(0, 0), 0.1f);
    }
    

  }

  void CambiarTexto(string ingl, string pro, string esp) {
    ingles.text = ingl;
    pronum.text = pro;
    espa.text = esp;
  }
}
