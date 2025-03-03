using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPlayerController : MonoBehaviour //a monobehavior is a script that can be attached
{
    public float speed;
    public float turnSpeed;
    public float horizontalInput;
    public float verticalInput;

    // Update is called once per frame
    void Update()
    {
        //Get input from user - do this in Update()
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // move the player forward with vertical input
        transform.Translate(Vector2.right * speed * Time.deltaTime * verticalInput);

        if (verticalInput < 0)
        {
            transform.Rotate(Vector3.back, -turnSpeed * Time.deltaTime * horizontalInput);
        }
        else
        {
            transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime * horizontalInput);
        }
    }
}
