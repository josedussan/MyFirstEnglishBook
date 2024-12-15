using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAnim : MonoBehaviour
{
  Button btn;
  public AudioSource asource;
  public AudioClip sonido;
  Vector3 upScale = new Vector3( 1.1f,1.1f,1);

  private void Awake()
  {
    btn = gameObject.GetComponent<Button>();
    btn.onClick.AddListener(Anim);
  }

  void Anim()
  {
    asource.PlayOneShot(sonido);
    LeanTween.scale(gameObject, upScale, 0.1f);
    LeanTween.scale(gameObject, Vector3.one, 0.1f).setDelay(0.1f);
  }
}
