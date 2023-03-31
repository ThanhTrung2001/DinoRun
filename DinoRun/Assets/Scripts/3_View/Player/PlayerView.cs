using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
  Animator animator;
  private void Start()
  {
    animator = GetComponent<Animator>();
  }

  public void JumpingAnimation()
  {
    animator.Play("Jump");
  }

  public void RunningAnimation()
  {
    animator.Play("Run");
  }
}
