using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {

        // public GameObject m_Instance;
        // TankHealth th= m_Instance.GetComponent<TankHealth>();

        //th.m_CurrentHealth += 15;
        Rigidbody targetRigidbody = other.GetComponent<Rigidbody>();
        //Debug.Log(th.m_CurrentHealth);
        int dmg = 25;
        if (other.name == "CompleteTank(Clone)")
        {

            TankHealth targetHealth = targetRigidbody.GetComponent<TankHealth>();
           
            Debug.Log("lol");
            Destroy(gameObject);
            targetHealth.Trapped(dmg);
            
        }
        // Debug.Log(targetHealth.);

        // Debug.Log(th.m_Slider.value);
        // other.tag.g
    }
}


