using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreatSpawn : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="CreateNewThreat")
        {
            Debug.Log(collision.name)   ;
            GameControl.instance.CreateThreat();

        }
        if (collision.gameObject.tag=="DeleteThreat")
        {
            Destroy(gameObject);
            
        }

    }
}
