﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene2 : MonoBehaviour
{
    void onTriggerEnter(Collider other){
        SceneManager.LoadScene(1); 
    }
}
