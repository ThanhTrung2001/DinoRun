using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour
{
  Animator animator;
  public GameObject gameOverPanel;
  private void Start()
  {
    animator = GetComponent<Animator>();
  }
  public void showGameOver()
  {
    gameOverPanel.SetActive(true);
  }
}
