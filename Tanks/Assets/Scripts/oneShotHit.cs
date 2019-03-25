using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneShotHit : MonoBehaviour
{
   
    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {

        Rigidbody targetRigidbody = other.GetComponent<Rigidbody>();
        //Debug.Log(th.m_CurrentHealth);
        int full_heal = 100;
        if (other.name == "CompleteTank(Clone)")
        {

            TankHealth targetHealth = targetRigidbody.GetComponent<TankHealth>();
            if (targetHealth.getHealth() < 100)
            {
                Debug.Log("lol");
                Destroy(gameObject);
                targetHealth.getFullPottion(full_heal);
            }
        }
    }
}