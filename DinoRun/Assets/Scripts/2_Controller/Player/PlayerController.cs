using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public PlayerModel model;
  public PlayerView view;
  Rigidbody2D body2d;
  // Start is called before the first frame update
  void Start()
  {
    model = new PlayerModel();
    view.transform.position = transform.position;
    body2d = GetComponent<Rigidbody2D>();    
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    Moving();
    Jumping();
  }
  
  void Moving()
  {
    view.transform.Translate(Vector3.right*model.speed*Time.deltaTime);
  }

  void Jumping()
  {
    if(model.isJump == false)
    {
      if(Input.GetKeyDown(KeyCode.Space) || Input.GetAxisRaw("Vertical") > 0)
      {
        view.JumpingAnimation();
        body2d.AddForce(Vector2.up*model.jumpForce,ForceMode2D.Impulse);
        model.Jumping();
      }
    }
  }

  private void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.CompareTag("Topographic"))
    {
      Debug.Log("block");
    }
    else if (other.gameObject.CompareTag("Ground"))
    {
      view.RunningAnimation();
      model.isGrounded();
    }
    else if(other.gameObject.CompareTag("Goal"))
    {
      GameController.Instance.setGameComplete();
    }
  }

  private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.CompareTag("DeathZone"))
    {
      GameController.Instance.setGameOver();
    }
  }
}
