using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movement_bear : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent _agent;
    private Animator anim;
    private float gravity = 800f;
    private float ySpeed;
    private float speed = 7f;
    void Start()
    {
        anim = GetComponent<Animator>();
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector3 movementDirection = new Vector3(0, 0, 0);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();

        ySpeed += Physics.gravity.y * Time.deltaTime;


        Vector3 velocity = movementDirection * magnitude;
        velocity.y = ySpeed;
    }
}
