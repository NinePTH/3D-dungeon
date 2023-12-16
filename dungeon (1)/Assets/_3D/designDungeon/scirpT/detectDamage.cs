using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectDamage : MonoBehaviour
{
    public bool beInFire;
    public bool stopDealDamage;
    public Stats _stats;
    Collider m_Collider;

    void Start()
    {
        m_Collider = GetComponent<Collider>();
        beInFire = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(beInFire && Input.GetButtonDown("Fire1"))
        {
            m_Collider.enabled = !m_Collider.enabled;
            
        }
    }

    void OnTriggerStay(Collider col)
    {
        if(col.tag == "Player")
        {
            //beInFire = true;
            Debug.Log("DealDamage");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.tag == "fire")
        {
            beInFire = false;
        }
    }

    /**IEnumerator DamageFromFire()
    {
        yield return new WaitForSeconds(1);
        _stats.health -= 10;
        stopDealDamage = false;
    }**/

}
