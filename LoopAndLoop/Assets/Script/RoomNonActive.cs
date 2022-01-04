using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomNonActive : MonoBehaviour
{

    private void Update()
    {
       
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("“–‚½‚Á‚½");
        if(collider.gameObject.CompareTag("Reroom"))
        {
            collider.gameObject.SetActive(false);
        }
    }
 
}
