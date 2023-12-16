using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    [SerializeField] public GameObject ob;
    public trapFire tF;
    // Start is called before the first frame update
    public bool trapActive;

    [SerializeField] public ParticleSystem  pSys;


    void OnTriggerEnter(Collider other)
    {
        if(other.tag ==  "Player")
        {
            //trapActive = true;
            tF.ShotFire(ob);
            
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if(other.tag ==  "Player")
        {
            trapActive = false;
        }
    }

    void Start()
    {      
        pSys.Stop();
    }

    // Update is called once per frame
   
}
