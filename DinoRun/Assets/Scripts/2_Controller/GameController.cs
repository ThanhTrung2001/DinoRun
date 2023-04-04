using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
  public GameView gameView;
  private GameObject dinorSelect;
  public GameModel gameModel;
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

  private void Start() 
  {
    gameModel.RestartGame();
    gameModel.SetScore();
    dinorSelect = MenuController.Instance.currentSelection.prefab;
    Debug.Log(dinorSelect);
    Instantiate(dinorSelect, new Vector3(-6.58f, -1.26f, 0),Quaternion.identity);
  }

  public void setGameOver()
  {
    gameModel.GameOver();
    gameView.ShowGameOver();
  }

  public void setGameComplete()
  {
    gameModel.GameOver();
    gameView.ShowGameComplete();
  }

  public void MenuClick()
  {
    SceneManager.LoadScene("Menu");
  }

  public void RestartClick()
  {
    SceneManager.LoadScene("Level");
  }
}
