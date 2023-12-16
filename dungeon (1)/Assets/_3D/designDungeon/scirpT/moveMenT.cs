using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMenT : MonoBehaviour
{
    
    private bool sL;
    //[SerializeField] public RigiBody rb;
    float speed = 7f;
    private float ySpeed;
    private float gravity = 800f;
    private float horizontalMovement;
    public float verticalMovement;
    private CharacterController character;
    private Vector3 movementDirection;
    private Vector3 destination  = Vector3.zero;
    [SerializeField] float rotationSpeed;
    //[SerializeField] fighter fighting;
    private Vector3 rotation;

    //public bool cb;
    private Animator animator;
    //combet
   

    void Start()
    {
        animator =  GetComponent<Animator>();
        character = GetComponent<CharacterController>(); //On Inspector
        sL = false;
    }
    
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal"); //button A and D
        verticalMovement = Input.GetAxis("Vertical"); //button W and S
        //Look();
    }

    void FixedUpdate()
    {
        MoveTwo();
        //fighting.attack(animator);
        //getItem();
    }

    

    void MoveTwo()
    {
        Vector3 movementDirection = new Vector3(horizontalMovement, 0, verticalMovement);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();

        ySpeed += Physics.gravity.y * Time.deltaTime;

        
        Vector3 velocity = movementDirection * magnitude;
        velocity.y = ySpeed;

        character.Move(velocity * Time.deltaTime);

        if(movementDirection != Vector3.zero)
        {
            animator.SetBool("walking", true);
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            animator.SetBool("walking", false);
        }

        //combet
        


    }

   
    void animatorationC()
    {
        if(destination != Vector3.zero)
        {
            animator.SetBool("walking", true);
        }else{
            animator.SetBool("walking", false);
        }
    }


    
       
}
