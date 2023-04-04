using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameView : MonoBehaviour
{
  Animator animator;
  public GameObject gameOverPanel;
  public TextMeshProUGUI gameText;
  private void Start()
  {
    animator = GetComponent<Animator>();
  }
  public void ShowGameOver()
  {
    gameText.text = "Game Over";
    gameOverPanel.SetActive(true);
  }

  public void ShowGameComplete()
  {
    gameText.text = "Game Complete";
    gameOverPanel.SetActive(true);
  }
}
