using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] // Encapsulation
    private float speed = 0.12f;
    private float zBound = 18.0f;
    private float xBound = 12.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer(); // Abstraction
        Boundary(); // Abstraction
    }

    // Moves the player based on arrow keys input
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * verticalInput);
        transform.Translate(Vector3.right * speed * horizontalInput);
    }

    // Prevent player from moving out of playing area
    void Boundary()
    {
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if(transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
    }
}
