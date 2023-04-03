using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : MonoBehaviour
{
  public bool isGameOver = false;
  public int score;

  public void SetScore()
  {
    score = 0;
  }
  public void IncreaseScore()
  {
    if(isGameOver == false)
    {
      score++;
    }
  }
  public void GameOver()
  {
    isGameOver = true;
  }
  public void RestartGame()
  {
    isGameOver = false;
  }
}
