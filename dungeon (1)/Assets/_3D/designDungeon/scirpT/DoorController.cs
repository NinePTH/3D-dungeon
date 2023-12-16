using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] GameObject doorOb;
    Animator _doorAnimate;
    public bool doorClosed = true;

    void Start()
    {
        _doorAnimate = doorOb.GetComponent<Animator>();        
    }

    private void OnTriggerEnter(Collider other)
    {   
        if(other.tag =="Player")
        {
            if(doorClosed)
            {
                //_doorAnimate.SetBool("Open",true); //opening the door
                doorClosed = false;
            
            }
            else
            {
                //_doorAnimate.SetBool("Open",false); //opening the door
                doorClosed = true;
            }
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(!doorClosed)
            {
                _doorAnimate.SetBool("Open",true);
                doorClosed = true;
            }
            else if(doorClosed)
            {
                _doorAnimate.SetBool("Open",false);
                doorClosed = false;
            }
        }
    }


}
