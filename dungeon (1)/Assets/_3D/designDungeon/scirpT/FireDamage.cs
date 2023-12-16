using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    private ParticleSystem _particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
        _particleSystem.Play();
    }

    void OnParticleCollision (GameObject other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Hit!");
            other.GetComponent<HealthSystem>().TakeDamage(3.0f);
        }
        
    }
}
