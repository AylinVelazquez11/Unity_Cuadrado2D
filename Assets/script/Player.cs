using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed=5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float HorizontalInput =Input.GetAxis("Horizontal");
      float VerticalInput = Input.GetAxis("Vertical");
      Vector3 mov = new Vector3(HorizontalInput,VerticalInput,0f) * Speed * Time.deltaTime;
      transform.position += mov;
    }
}
