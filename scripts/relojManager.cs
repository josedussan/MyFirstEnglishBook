using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class relojManager : MonoBehaviour
{
  public GameObject minutero, hora;
  public AudioSource aSource;
  public List<AudioClip> audios;
  public float anguloGrados;
  public Camera camera;
  // Start is called before the first frame update
  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

  }

  public void DragHora()
  {
    float anguloRadianes = Mathf.Atan2(Input.mousePosition.y - hora.transform.position.y, Input.mousePosition.x - hora.transform.position.x);
    float anguloGrados = (180 / Mathf.PI) * anguloRadianes;
    hora.transform.rotation = Quaternion.Euler(0,0,anguloGrados);
  }

  public void DragMinutero()
  {
    float anguloRadianes = Mathf.Atan2(Input.mousePosition.y - minutero.transform.position.y, Input.mousePosition.x - minutero.transform.position.x);
    anguloGrados = (180 / Mathf.PI) * anguloRadianes - 90;
    minutero.transform.rotation = Quaternion.Euler(0, 0, anguloGrados);


  }

  public void DropMinutero()
  {
    Debug.Log(anguloGrados);
    if ((anguloGrados <= -23f) && (anguloGrados >= -37f))
    {
      aSource.PlayOneShot(audios[0]);
    } else if ((anguloGrados <= -52f) && (anguloGrados >= -67f))
    {
        aSource.PlayOneShot(audios[1]);
    }
    else if ((anguloGrados <= -83f) && (anguloGrados >= -97f))
    {
      aSource.PlayOneShot(audios[2]);
    }
    else if ((anguloGrados <= -113f) && (anguloGrados >= -127f))
    {
      aSource.PlayOneShot(audios[3]);
    }
    else if ((anguloGrados <= -142f) && (anguloGrados >= -157f))
    {
      aSource.PlayOneShot(audios[4]);
    }
    else if ((anguloGrados <= -173f) && (anguloGrados >= -187f))
    {
      aSource.PlayOneShot(audios[5]);
    }
    else if ((anguloGrados <= -203f) && (anguloGrados >= -217f))
    {
      aSource.PlayOneShot(audios[6]);
    }
    else if ((anguloGrados <= -233f) && (anguloGrados >= -248f))
    {
      aSource.PlayOneShot(audios[7]);
    }
    else if ((anguloGrados >= 83f) && (anguloGrados >= -263f))
    {
      aSource.PlayOneShot(audios[8]);
    }
    else if ((anguloGrados >= 53f) && (anguloGrados <= 66f))
    {
      aSource.PlayOneShot(audios[9]);
    }
    else if ((anguloGrados >= 24f) && (anguloGrados <= 35f))
    {
      aSource.PlayOneShot(audios[10]);
    }
    else if ((anguloGrados >= -6f) && (anguloGrados <= 6f))
    {
      aSource.PlayOneShot(audios[11]);
    }

  }
}
