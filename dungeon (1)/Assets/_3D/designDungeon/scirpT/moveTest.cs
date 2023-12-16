using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTest : MonoBehaviour
{
    public float speed;
    private float gravity;
    public float horizontalMovement;
    public float verticalMovement;
    public Vector3 v_movememt;
    public Vector3 v_velocity;
    CharacterController character;
    [SerializeField] float sR;

    void Start()
    {
        character = GetComponent<CharacterController>();
        speed = 7f;
        gravity = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal"); //button A and D
        verticalMovement = Input.GetAxis("Vertical"); //button W and S
    }

    private void FixedUpdate()
    {
        v_movememt = character.transform.forward*verticalMovement;

        character.transform.Rotate(Vector3.up * horizontalMovement * (sR * Time.deltaTime));

        character.Move(v_movememt * speed * Time.deltaTime);
    }
}
