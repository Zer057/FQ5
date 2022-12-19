using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private Rigidbody playerRb;
    public float jumpforce = 10;
    public float gravityModifier;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRb.AddForce(Vector3.right * speed * horizontalInput);        
        //playerRb.AddForce(Vector3.left * speed * horizontalInput);      

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            
        }  

        if (transform.position.x < -14){
            Debug.Log("Wrong Way!");
        } else {
            Debug.Log("");
        }

    }
}
