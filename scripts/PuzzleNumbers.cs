using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PuzzleNumbers : MonoBehaviour
{
  public GameObject cero, ceroblack, uno, unoblack, dos, dosblack, textocero, textouno, textodos, textotres;
  public GameObject tres, cuatro, cinco, tresblack, cuatroblack, cincoblack, textocuatro, textocinco, textoseis;
  public GameObject seis, siete, ocho, seisblack, sieteblack, ochoblack,nueve,nueveblack, textosiete, textoocho, textonueve;
  public AudioClip incorrecto;
  public AudioSource aSource;
  public List<AudioClip> audios;

  Vector3 ceroInitialPos, unoInitialPos, dosInitialPos,tresInitialPos, cuatroInitialPos, cincoInitialPos, seisInitialPos, sieteInitialPos, ochoInitialPos, nueveInitialPos;
  // Start is called before the first frame update
  void Start()
    {
      ceroInitialPos = cero.transform.position;
      unoInitialPos = uno.transform.position;
      dosInitialPos = dos.transform.position;
      tresInitialPos = tres.transform.position;
      cuatroInitialPos = cuatro.transform.position;
      cincoInitialPos = cinco.transform.position;
      seisInitialPos = seis.transform.position;
      sieteInitialPos = siete.transform.position;
      ochoInitialPos = ocho.transform.position;
      nueveInitialPos = nueve.transform.position;
    Debug.Log("posicion cero");
      Debug.Log(ceroInitialPos);
  }
  public void DragCero()
  {
    cero.transform.position = Input.mousePosition;
    Debug.Log("entra al arrastrar");
  }
  public void DragUno()
  {
    uno.transform.position = Input.mousePosition;
  }
  public void DragDos()
  {
    dos.transform.position = Input.mousePosition;
  }
  public void DragTres()
  {
    tres.transform.position = Input.mousePosition;
  }
  public void DragCuatro()
  {
    cuatro.transform.position = Input.mousePosition;
  }
  public void DragCinco()
  {
    cinco.transform.position = Input.mousePosition;
  }
  public void DragSeis()
  {
    seis.transform.position = Input.mousePosition;
  }
  public void DragSiete()
  {
    siete.transform.position = Input.mousePosition;
  }
  public void DragOcho()
  {
    ocho.transform.position = Input.mousePosition;
  }
  public void DragNueve()
  {
    nueve.transform.position = Input.mousePosition;
  }

  public void DropCero()
  {
    float distance = Vector3.Distance(cero.transform.position, ceroblack.transform.position);
    if (distance < 50)
    {
      Debug.Log("cerca");
      cero.transform.position = ceroblack.transform.position;
      aSource.PlayOneShot(audios[0]);
      textocero.transform.DOScale(new Vector3(1, 1, 1), 0.2f);

    }
    else
    {
      Debug.Log("lejos");
      cero.transform.position = ceroInitialPos;
      Debug.Log(ceroInitialPos);
      aSource.PlayOneShot(incorrecto);
    }
  }

  public void DropUno()
  {
    float distance = Vector3.Distance(uno.transform.position, unoblack.transform.position);
    if (distance < 50)
    {
      uno.transform.position = unoblack.transform.position;
      aSource.PlayOneShot(audios[1]);
      textouno.transform.DOScale(new Vector3(1, 1, 1), 0.2f);

    }
    else
    {
      uno.transform.position = unoInitialPos;
      aSource.PlayOneShot(incorrecto);
    }
  }

  public void DropDos()
  {
    float distance = Vector3.Distance(dos.transform.position, dosblack.transform.position);
    if (distance < 50)
    {
      dos.transform.position = dosblack.transform.position;
      aSource.PlayOneShot(audios[2]);
      textodos.transform.DOScale(new Vector3(1, 1, 1), 0.2f);

    }
    else
    {
      dos.transform.position = dosInitialPos;
      aSource.PlayOneShot(incorrecto);
    }
  }

  public void DropTres()
  {
    float distance = Vector3.Distance(tres.transform.position, tresblack.transform.position);
    if (distance < 50)
    {
      tres.transform.position = tresblack.transform.position;
      aSource.PlayOneShot(audios[3]);
      textotres.transform.DOScale(new Vector3(1, 1, 1), 0.2f);

    }
    else
    {
      tres.transform.position = tresInitialPos;
      aSource.PlayOneShot(incorrecto);
    }
  }

  public void DropCuatro()
  {
    float distance = Vector3.Distance(cuatro.transform.position, cuatroblack.transform.position);
    if (distance < 50)
    {
      cuatro.transform.position = cuatroblack.transform.position;
      aSource.PlayOneShot(audios[4]);
      textocuatro.transform.DOScale(new Vector3(1, 1, 1), 0.2f);

    }
    else
    {
      cuatro.transform.position = cuatroInitialPos;
      aSource.PlayOneShot(incorrecto);
    }
  }

  public void DropCinco()
  {
    float distance = Vector3.Distance(cinco.transform.position, cincoblack.transform.position);
    if (distance < 50)
    {
      cinco.transform.position = cincoblack.transform.position;
      aSource.PlayOneShot(audios[5]);
      textocinco.transform.DOScale(new Vector3(1, 1, 1), 0.2f);

    }
    else
    {
      cinco.transform.position = cincoInitialPos;
      aSource.PlayOneShot(incorrecto);
    }
  }

  public void DropSeis()
  {
    float distance = Vector3.Distance(seis.transform.position, seisblack.transform.position);
    if (distance < 50)
    {
      seis.transform.position = seisblack.transform.position;
      aSource.PlayOneShot(audios[6]);
      textoseis.transform.DOScale(new Vector3(1, 1, 1), 0.2f);

    }
    else
    {
      seis.transform.position = seisInitialPos;
      aSource.PlayOneShot(incorrecto);
    }
  }

  public void DropSiete()
  {
    float distance = Vector3.Distance(siete.transform.position, sieteblack.transform.position);
    if (distance < 50)
    {
      siete.transform.position = sieteblack.transform.position;
      aSource.PlayOneShot(audios[7]);
      textosiete.transform.DOScale(new Vector3(1, 1, 1), 0.2f);

    }
    else
    {
      siete.transform.position = sieteInitialPos;
      aSource.PlayOneShot(incorrecto);
    }
  }

  public void DropOcho()
  {
    float distance = Vector3.Distance(ocho.transform.position, ochoblack.transform.position);
    if (distance < 50)
    {
      ocho.transform.position = ochoblack.transform.position;
      aSource.PlayOneShot(audios[8]);
      textoocho.transform.DOScale(new Vector3(1, 1, 1), 0.2f);

    }
    else
    {
      ocho.transform.position = ochoInitialPos;
      aSource.PlayOneShot(incorrecto);
    }
  }

  public void DropNueve()
  {
    float distance = Vector3.Distance(nueve.transform.position, nueveblack.transform.position);
    if (distance < 50)
    {
      nueve.transform.position = nueveblack.transform.position;
      aSource.PlayOneShot(audios[9]);
      textonueve.transform.DOScale(new Vector3(1, 1, 1), 0.2f);

    }
    else
    {
      nueve.transform.position = nueveInitialPos;
      aSource.PlayOneShot(incorrecto);
    }
  }

  public void reiniciar()
  {
    cero.transform.position = ceroInitialPos;
    //cero.transform.DOMove(ceroInitialPos, 0.2f);
    //cero.transform.DOShakePosition(ceroInitialPos, 0.2f);
    uno.transform.position = unoInitialPos;
    dos.transform.position = dosInitialPos;
    tres.transform.position = tresInitialPos;
    cuatro.transform.position = cuatroInitialPos;
    cinco.transform.position = cincoInitialPos;
    seis.transform.position = seisInitialPos;
    siete.transform.position = sieteInitialPos;
    ocho.transform.position = ochoInitialPos;
    nueve.transform.position = nueveInitialPos;
    textocero.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
    textouno.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
    textodos.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
    textotres.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
    textocuatro.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
    textocinco.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
    textoseis.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
    textosiete.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
    textoocho.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
    textonueve.transform.DOScale(new Vector3(0, 0, 0), 0.2f);
  }
  // Update is called once per frame
  void Update()
    {
        
    }
}
