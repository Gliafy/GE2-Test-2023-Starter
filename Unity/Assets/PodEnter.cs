using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodEnter : MonoBehaviour
{
    public GameObject player;
    public GameObject Boid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("HAHAHAH");
        if(collider.tag == "MainCamera")   
        {
            Boid.transform.parent = player.transform;
        }
        
    }
}
