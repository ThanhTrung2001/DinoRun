using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
  public float speed = 4f; //speed
  public bool isJump = false; // check Jumping

  public float jumpForce = 8f;
  public void Jumping()
  {
    isJump = true;
  }

  public void isGrounded()
  {
    isJump = false;
  }

}
