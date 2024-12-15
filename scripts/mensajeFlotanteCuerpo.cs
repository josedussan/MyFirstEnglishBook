using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class mensajeFlotanteCuerpo : MonoBehaviour
{
    public Text txtingles, txtespanol, txtpronunciacion;
    public Image imagencuerpo;
  public GameObject panel;
    public RectTransform panelRx;
  public List<Sprite> partesCuerpo;
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
        txtingles.text = "HEAD";
        txtespanol.text = "Cabeza";
        txtpronunciacion.text = "(jed)";
        imagencuerpo.sprite = partesCuerpo[0];
        break;
      case 1:
        txtingles.text = "EAR";
        txtespanol.text = "Oído";
        txtpronunciacion.text = "(iar)";
        imagencuerpo.sprite = partesCuerpo[1];
        break;
      case 2:
        txtingles.text = "NOSE";
        txtespanol.text = "Nariz";
        txtpronunciacion.text = "(nóus)";
        imagencuerpo.sprite = partesCuerpo[2];
        break;
      case 3:
        txtingles.text = "BACK";
        txtespanol.text = "Espalda";
        txtpronunciacion.text = "(bac)";
        imagencuerpo.sprite = partesCuerpo[3];
        break;
      case 4:
        txtingles.text = "HAND";
        txtespanol.text = "Mano";
        txtpronunciacion.text = "(jend)";
        imagencuerpo.sprite = partesCuerpo[4];
        break;
      case 5:
        txtingles.text = "CHEST";
        txtespanol.text = "Pecho";
        txtpronunciacion.text = "(shees)";
        imagencuerpo.sprite = partesCuerpo[5];
        break;
      case 6:
        txtingles.text = "FEET";
        txtespanol.text = "Pies";
        txtpronunciacion.text = "(fit)";
        imagencuerpo.sprite = partesCuerpo[6];
        break;
      case 7:
        txtingles.text = "FOOT";
        txtespanol.text = "Pié";
        txtpronunciacion.text = "(fut)";
        imagencuerpo.sprite = partesCuerpo[7];
        break;
      case 8:
        txtingles.text = "LEGS";
        txtespanol.text = "Piernas";
        txtpronunciacion.text = "(legs)";
        imagencuerpo.sprite = partesCuerpo[8];
        break;
      case 9:
        txtingles.text = "ARM";
        txtespanol.text = "Brazo";
        txtpronunciacion.text = "(arms)";
        imagencuerpo.sprite = partesCuerpo[9];
        break;
      case 10:
        txtingles.text = "MOUTH";
        txtespanol.text = "Boca";
        txtpronunciacion.text = "(máus)";
        imagencuerpo.sprite = partesCuerpo[10];
        break;
      case 11:
        txtingles.text = "EYE";
        txtespanol.text = "Ojo";
        txtpronunciacion.text = "(ái)";
        imagencuerpo.sprite = partesCuerpo[11];
        break;
      case 12:
        txtingles.text = "SHOULDER";
        txtespanol.text = "Hombro";
        txtpronunciacion.text = "(chólder)";
        imagencuerpo.sprite = partesCuerpo[12];
        break;
      case 13:
        txtingles.text = "HEART";
        txtespanol.text = "Corazón";
        txtpronunciacion.text = "(jart)";
        imagencuerpo.sprite = partesCuerpo[13];
        break;
      case 14:
        txtingles.text = "STOMACH";
        txtespanol.text = "Estómago";
        txtpronunciacion.text = "(stomach)";
        imagencuerpo.sprite = partesCuerpo[14];
        break;
    }
    panel.transform.DOScale(new Vector3(1, 1, 1), 0.25f);
  }

  public void cerrarPanel()
  {
    panel.transform.DOScale(new Vector3(0, 0, 0), 0.25f);
  }

  public void activarPanelRX()
  {
    panelRx.DOAnchorPos(new Vector2(0,-68), 0.25f);
  }
  public void desactivarPanelRX()
  {
    panelRx.DOAnchorPos(new Vector2(1600,-68), 0.25f);
  }
  public void activarAudio()
  {
    asource.PlayOneShot(audios[numeroaudio]);
  }
}

