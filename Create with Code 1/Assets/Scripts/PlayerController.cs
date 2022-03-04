using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Inout collecting
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(0,0,1);

        //Move forward backword based on time and input
        transform.Translate(Vector3.forward * Time.deltaTime *speed * verticalInput); // 5 meter per second
        //transform.Translate(Vector3.forward ); //1 Meter per frame

        //Rotate
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed *horizontalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput); 
    }
}
