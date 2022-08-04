using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

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

        /*  This is really bad code. I essentially have the 'else' doing the exact same thing as it still needs xMove and yMove to update on no movement to initiate
            idle state in the animator */

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

        LoadBattle();

    }

    // Update is called once per frame
    void Update()
    {
        theRB.MovePosition(theRB.position + movement * movementSpeed * Time.deltaTime);

    }

    void LoadBattle()
    {
        float rng = Random.Range(0, 3000);
        if (rng < 50)
        {
            SceneManager.LoadScene(1);
        }
    }
}
