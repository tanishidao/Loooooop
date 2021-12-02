using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    private Vector3 PlayerPosision;
    private float Ypos = 5f;
    public GameObject Reroom;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       PlayerPosision =  this.gameObject.transform.position;

        if(PlayerPosision.y > Ypos  )
        {
            Instantiate(Reroom, new Vector3(-1.88f, Ypos+5f, 0), Quaternion.identity);
            Debug.Log("seisei");
            Ypos += 2.5f;
        }
    }
}
