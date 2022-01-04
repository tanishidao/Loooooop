using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using System;
public class GameQuit : MonoBehaviour
{
    public bool Continue = false;
    public MouseLook mouseLook;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameTojiru()
    {
        Application.Quit();
        Debug.Log("ÉQÅ[ÉÄï¬Ç∂ÇÈ");
    }
   
}
