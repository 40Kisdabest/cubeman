using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
     private float _speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector3.down * _speed * Time.deltaTime); 

       if(transform.position.y <= -8.0f)
       {
        transform.position = new Vector3(Random.Range(-3.8f, 3.8f), 8, 0);
     
       }
     
    }

    private void OnTriggerEnter(Collider other)
    {
     if(other.tag == "Player")
       {
        Destroy(this.gameObject);
       }

       if(other.tag == "Laser")
       {
        //Destroy(laser);
        Destroy(this.gameObject);
       }
       //testing the git hub
    }
    
}


