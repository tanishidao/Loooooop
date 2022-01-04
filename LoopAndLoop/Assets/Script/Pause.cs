using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Pause : MonoBehaviour
{
    
    
    public MouseLook mouseLook;
    

    private void Update()
    {
        
       
        if(mouseLook.Gray)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
  

}
