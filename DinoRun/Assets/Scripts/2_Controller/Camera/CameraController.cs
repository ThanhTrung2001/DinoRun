using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  public float speed = 4f;
  public Vector3 cameraPosition;
  // Start is called before the first frame update
  void Start()
  {
    cameraPosition = transform.position;
  }

  // Update is called once per frame
  void Update()
  {
    if(GameController.Instance.gameModel.isGameOver == false) 
    {
      CameraMoving();
    }
  }

  void CameraMoving()
  {
    transform.Translate(1*speed*Time.deltaTime, 0 , 0);
    cameraPosition = transform.position;
  }
}
