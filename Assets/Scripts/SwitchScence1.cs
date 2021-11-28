using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class SwitchScence1 : MonoBehaviour
{
    //load big scene
    void onTriggerEnter(Collider other){
        SceneManager.LoadScene(0); 
    }
}
