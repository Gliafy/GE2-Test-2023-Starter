using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachinePod : MonoBehaviour
{
    public abstract class State
    {
        public StateMachine owner;
        public virtual void Enter() { }
        public virtual void Exit() { }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
