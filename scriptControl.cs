using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class scriptControl : MonoBehaviour
{
  public RectTransform panelMain;
    // Start is called before the first frame update
    void Start()
    {
      panelMain.DOAnchorPos(Vector2.zero,0.01f);
      GameObject.Find("contenidoPrincipal").GetComponent<RectTransform>().LeanSetPosY(-284);
        if (variables.marcador=="atras") {
      if (variables.escena == "vowels" || variables.escena == "vocabulary" || variables.escena == "numbers" || variables.escena == "ordinalNumbers" || variables.escena == "colors" || variables.escena == "shapes") {
        mostrarPanel(GameObject.Find("panelUnidad1").GetComponent<RectTransform>());
      } else if (variables.escena == "commands" || variables.escena == "schoolSupplies" || variables.escena == "fruits" || variables.escena == "vegetables" || variables.escena == "week" || variables.escena == "month")
      {
        mostrarPanel(GameObject.Find("panelUnidad2").GetComponent<RectTransform>());
      } else if (variables.escena == "family" || variables.escena == "body" || variables.escena == "fiveSenses" || variables.escena == "animals" || variables.escena == "wildAnimals" || variables.escena == "emotions")
      {
        mostrarPanel(GameObject.Find("panelUnidad3").GetComponent<RectTransform>());
      } else if (variables.escena == "house" || variables.escena == "partsHouse" || variables.escena == "kitchen" || variables.escena == "bedroom" || variables.escena == "bathroom")
      {
        mostrarPanel(GameObject.Find("panelUnidad4").GetComponent<RectTransform>());
      } else if (variables.escena == "transport" || variables.escena == "profession" || variables.escena == "food" || variables.escena == "fastfood" || variables.escena == "city" || variables.escena == "clothes" || variables.escena == "sports")
      {
        mostrarPanel(GameObject.Find("panelUnidad5").GetComponent<RectTransform>());
      }
      else if (variables.escena == "instruments" || variables.escena == "computer" || variables.escena == "computerParts" || variables.escena == "season" || variables.escena == "climate" || variables.escena == "time" || variables.escena == "traffic" || variables.escena == "solar")
      {
        mostrarPanel(GameObject.Find("panelUnidad6").GetComponent<RectTransform>());
      }

    }
    }

    // Update is called once per frame
    public void mostrarPanel(RectTransform panel)
    {
      panelMain.DOAnchorPos(new Vector2(-900,0), 0.25f).SetDelay(0.2f);
      panel.DOAnchorPos(Vector2.zero, 0.25f).SetDelay(0.2f); 
    }
  public void cerrarPanel(RectTransform panel)
  {
    panelMain.DOAnchorPos(Vector2.zero,0.25f).SetDelay(0.2f); ;
    panel.DOAnchorPos(new Vector2(900, 0), 0.25f).SetDelay(0.2f); 
  }

  public void CerrarApp() {
    Application.Quit();
  }

  public void vistPrevia(RectTransform vistprevia) {

    vistprevia.DOScale(new Vector2(1,1),0.25f);
    vistprevia.DOScale(Vector2.zero, 0.25f).SetDelay(1.5f);
  }

}
