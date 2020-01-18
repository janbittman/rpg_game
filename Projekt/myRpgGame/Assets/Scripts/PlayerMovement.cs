using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidBody2D;
    private Vector3 change;



    // Start is called before the first frame update
    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();  
        
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        Debug.Log(change);
        if (change != Vector3.zero)
        {
            MoveCharacter();
        }
    }
    void MoveCharacter()
    {
        myRigidBody2D.MovePosition(transform.position + change.normalized * speed * Time.deltaTime);
    }


}
