using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public PlayerModel model;
  public PlayerView view;
  // Start is called before the first frame update
  void Start()
  {
    model = new PlayerModel();
    view.transform.position = transform.position;    
  }

  // Update is called once per frame
  void Update()
  {
    Moving();
  }
  
  void Moving()
  {
    view.transform.Translate(Vector3.right*model.speed*Time.deltaTime);
  }

  private void OnCollisionEnter2D(Collision2D other) {
    if(other.gameObject.CompareTag("Topographic"))
    {
      Debug.Log("block");
    }
  }

  private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.CompareTag("DeathZone"))
    {
      Debug.Log("Game Over!");
    }
  }
}
