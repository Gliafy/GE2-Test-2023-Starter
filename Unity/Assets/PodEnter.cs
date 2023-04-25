using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodEnter : MonoBehaviour
{
    public GameObject player;
    public GameObject Boids;
    
    
    public float speed = 5f;
    

    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindWithTag("Fish");


       // speed = Boids.GetComponent<Boid>().maxSpeed;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
       // if (Input.GetKeyDown(KeyCode.P))
        //{
        //    Boid.transform.position = player.transform.position + Vector3.down * 1.5f + Vector3.back * 2f;
        //    Boid.transform.parent = player.transform;
        //    speed = 0;
       // }
       if(Input.GetKeyDown(KeyCode.Z))
        {

            Boids.transform.parent = null;
            speed = 5;
            player.transform.position += Vector3.up * 10;   
        }    
    }
   private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("MainCamera"))
        {
            Boids.transform.position = player.transform.position + Vector3.down * 1.5f + Vector3.back * 3f;
            Boids.transform.parent = player.transform;
                speed = 0;
        }
    }
    // private void OnTriggerEnter(Collider collider)
    // {
    //    Debug.Log("HAHAHAH");
    //   if(collider.tag == "MainCamera")   
    //   {
    //      Boid.transform.parent = player.transform;
    //  }

    //  }
}
