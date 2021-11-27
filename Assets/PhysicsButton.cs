using System.Collections;
using System.Collections.Generic;
using System; 
using UnityEngine;
using UnityEngine.Events;

public class PhysicsButton : MonoBehaviour
{

    [SerializeField] private float threshold = 0.1f; 
    [SerializeField] private float deadZone = 0.025f; //prevents any extra wiggling that will trigger the button 
    private bool isPressed; //will trigger the push function 
    private Vector3 startPos; //will help dectect if ther was movement 
    private ConfigurableJoint _joint; 

    public UnityEvent onPressed, onReleased; 
    void Start()
    {
        startPos = transform.localPosition; 
        _joint = GetComponent<ConfigurableJoint>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        //check if pressed
        if(!isPressed && GetValue() +threshold >= 1){
            Pressed();
        }

        //check if released
        if(isPressed && GetValue() + threshold <= 0){
            Released(); 
        }
    }

    private float GetValue(){
        var val= Vector3.Distance(startPos, transform.localPosition) / _joint.linearLimit.limit; 

        if(Math.Abs(val) < deadZone)
            val = 0; 

        return Mathf.Clamp(val, -1f, 1f); 
    }

    private void Pressed(){
        isPressed = true; 
        onPressed.Invoke();
        Debug.Log("Pressed");
    }  

    private void Released(){
        isPressed = false; 
        onReleased.Invoke();
        Debug.Log("Released");
    }
}
