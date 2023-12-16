using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dealDamage : MonoBehaviour
{
    public Stats _stats;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if(col.tag == "Fire")
        {
            Debug.Log("You're dealt damage.");
            _stats.health -= 5;
        }
    }
}
