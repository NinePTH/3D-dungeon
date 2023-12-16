using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapFire : MonoBehaviour
{  
    //[Header("Variable")]
    private Vector3 destination;
    [SerializeField] GameObject obT;
    [SerializeField] private GameObject preFab;
    public Transform FirstPoint;
    //public GameObject [] targets;
    public float Force = 20f;
    public float fireRate;
    private float nextFire = 0.0F;

    public void ShotFire(GameObject target)
    {
        //Debug.Log("ShotFire");
        GameObject fireball = Instantiate(preFab, FirstPoint.position, Quaternion.identity);
        Vector3 shoot = (target.transform.position - this.transform.position).normalized;
        Rigidbody rb = fireball.GetComponent<Rigidbody>();
        rb.AddForce(shoot * Force, ForceMode.Impulse);
        
    }
}
