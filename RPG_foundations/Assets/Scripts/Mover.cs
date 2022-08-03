using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{
    private Rigidbody theRB;
    Animator anim;
    private Vector3 movement;
    [SerializeField] private int movementSpeed = 5;

    public SpriteRenderer theSR;


    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void OnMovement(InputValue value)
    {
        movement = value.Get<Vector3>();

        if (movement != Vector3.zero)
        {
            anim.SetFloat("xMove", movement.x);
            anim.SetFloat("yMove", movement.z);
        }
        else
        {
            anim.SetFloat("xMove", movement.x);
            anim.SetFloat("yMove", movement.z);
        }

        if (!theSR.flipX && movement.x < 0)
        {
            theSR.flipX = true;
        }
        else if (theSR.flipX && movement.x > 0)
        {
            theSR.flipX = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        theRB.MovePosition(theRB.position + movement * movementSpeed * Time.deltaTime);

    }
}
