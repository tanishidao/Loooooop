using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstaItem : MonoBehaviour
{
    private Vector3 PlayerPosision;
    private float Ypos = 5f;
    public GameObject Reroom;
    public GameObject Ball;
    private int spawnCount;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       PlayerPosision =  this.gameObject.transform.position;

        if(PlayerPosision.y > Ypos  )
        {
            Ypos += 2.5f;
            Instantiate(Reroom, new Vector3(-1.88f, Ypos+2.5f, 0), Quaternion.identity);
            Instantiate(Ball, new Vector3(0, Ypos + 2.5f, 0), Quaternion.identity);
            
            Debug.Log("åªç›"+spawnCount+"äKê∂ê¨");
            spawnCount++;
        }
        
    }
    
}
