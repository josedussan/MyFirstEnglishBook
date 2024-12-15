using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class panelManagerNumbers : MonoBehaviour
{
  public RectTransform panelDiez,panelVeinte,tipPrincipal,tipDiez,panelEvaluacion, panelEvaluacionListen, panelEvaluacionSpeak, panelEvaluacionWrite;
  // Start is called before the first frame update
  public Image touch, scroll1,touchlisten,touchspeak;
  void Start()
    {
      
    }

    // Update is called once per frame
    public void activarPanelDiez()
    {
      panelDiez.DOAnchorPos(Vector2.zero, 0.25f); 
    }
    public void desactivarPanelDiez()
    {
      panelDiez.DOAnchorPos(new Vector2(0,1600), 0.25f);
    }
    public void activarPanelVeinte()
    {
      panelVeinte.DOAnchorPos(Vector2.zero, 0.25f);
    }
    public void desactivarPanelVeinte()
    {
      panelVeinte.DOAnchorPos(new Vector2(0, 1600), 0.25f);
    }
    public void activarPanelTipPrincipal()
    {
      tipPrincipal.DOAnchorPos(Vector2.zero ,0.25f);
    }
    public void desactivarPanelTipPrincipal()
    {
    tipPrincipal.DOAnchorPos(new Vector2(0,-1600), 0.25f);
    }
  public void activarPanelTipDiez()
  {
    tipDiez.DOAnchorPos(Vector2.zero, 0.25f);
  }
  public void desactivarPanelTipDiez()
  {
    tipDiez.DOAnchorPos(new Vector2(0, -1600), 0.25f);
  }
  public void activarPanelEvaluacion()
  {
    panelEvaluacion.DOAnchorPos(Vector2.zero, 0.25f);
  }
  public void desactivarPanelEvaluacion()
  {
    panelEvaluacion.DOAnchorPos(new Vector2(1600,0), 0.25f);
  }

  public void activarPanelEvaluacionListen()
  {
    
    panelEvaluacionListen.DOAnchorPos(Vector2.zero, 0.25f);
    touchlisten.transform.DOScale(new Vector2(0.6f, 0.6f), 0.35f);
    touchlisten.transform.DOScale(new Vector2(0, 0), 0.1f).SetDelay(3);
  }
  public void desactivarPanelEvaluacionListen()
  {
    panelEvaluacionListen.DOAnchorPos(new Vector2(1600, 0), 0.25f);
  }

  public void activarPanelEvaluacionSpeak()
  {
    panelEvaluacionSpeak.DOAnchorPos(Vector2.zero, 0.25f);
    touchspeak.transform.DOScale(new Vector2(0.6f, 0.6f), 0.35f);
    touchspeak.transform.DOScale(new Vector2(0, 0), 0.1f).SetDelay(3);
  }
  public void desactivarPanelEvaluacionSpeak()
  {
    panelEvaluacionSpeak.DOAnchorPos(new Vector2(1600, 0), 0.25f);
  }

  public void activarPanelEvaluacionWrite()
  {
    panelEvaluacionWrite.DOAnchorPos(Vector2.zero, 0.25f);
  }
  public void desactivarPanelEvaluacionWrite()
  {
    panelEvaluacionWrite.DOAnchorPos(new Vector2(1600, 0), 0.25f);
  }

  public void activarAyuda(bool scroll) {
    touch.transform.DOScale(new Vector2(0.6f, 0.6f), 0.1f);
    touch.transform.DOScale(new Vector2(0,0), 0.1f).SetDelay(3);
    if (scroll) {
      scroll1.transform.DOScale(new Vector2(0.6f,0.6f),0.2f).SetDelay(3);
      scroll1.transform.DOScale(new Vector2(0, 0), 0.1f).SetDelay(8);
    }
  }


}
