using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Vector3 playerPosition;
    public float speed;

    public Rigidbody playerBody;
    public bool isGrounded;

    void Update()
    {

        //Player Movement
        playerPosition.x = Input.GetAxis("Horizontal");
        transform.Translate(playerPosition * speed * Time.deltaTime);


        //PLayer Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerBody.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            isGrounded = false;
        }

    }


    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }

    }
}
