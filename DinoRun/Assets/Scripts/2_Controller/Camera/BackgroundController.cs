using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
  public float speed = 4f;

  public new CameraController camera;
  // Start is called before the first frame update
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
    InfinityBackground();
  }

  void InfinityBackground()
  {
    if(camera.cameraPosition.x - 9.12f > transform.position.x)
    {
      transform.position = new Vector3(camera.cameraPosition.x + 9.12f,transform.position.y,transform.position.z);
    }
  }
}
