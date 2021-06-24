using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentSpeed : MonoBehaviour
{
    private float speed = 100f;
    private Vector2 movement;
    private Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {

        movement = new Vector2(Input.GetAxis("Horizontal"),0);

    }
    private void FixedUpdate()
    {
        movementSpeed(movement);
    }

    void movementSpeed(Vector2 direction)
    {
        RB.AddForce(direction * speed);
    }
}
