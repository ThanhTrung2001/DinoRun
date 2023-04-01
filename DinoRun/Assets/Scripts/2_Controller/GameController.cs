using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  private GameObject dinorSelect;
  public static GameController Instance{get; private set;}
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
    dinorSelect = MenuController.Instance.currentSelection.prefab;
    Debug.Log(dinorSelect);
    Instantiate(dinorSelect, new Vector3(-6.58f, -1.26f, 0),Quaternion.identity);
  }
}
