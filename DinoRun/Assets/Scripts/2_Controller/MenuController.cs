using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
  public SelectionModel[] selections;
  public SelectionModel currentSelection;
  public GameObject optionPanel;
  public static MenuController Instance{get; private set;}
  private void Awake() 
  {
    if (Instance != null && Instance != this) 
    { 
        Destroy(this); 
    } 
    else 
    { 
        Instance = this; 
    } 
  }
  private void Start() {
    if(selections.Length > 0)
    {
      currentSelection = selections[0];
    }
  }

  public void SelectBlueCharacter()
  {
    currentSelection = selections[0];
  }

  public void SelectRedCharacter()
  {
    currentSelection = selections[1];
  }
  public void Play()
  {
    SceneManager.LoadScene("Level");
  }
  public void Option()
  {
    optionPanel.SetActive(true);
  }

  public void CloseOption()
  {
    optionPanel.SetActive(false);
  }
}
