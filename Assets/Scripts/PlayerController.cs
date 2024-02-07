using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
public float speed = 5f;

    void Start()
    {
        // No initialization needed for Start()
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        movement.Normalize(); // Normalize the movement vector to prevent faster diagonal movement

        transform.Translate(movement * speed * Time.deltaTime);
    }
}
