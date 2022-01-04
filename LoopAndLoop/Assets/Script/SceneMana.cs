using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMana : MonoBehaviour
{
    public string cubeTag = "Cube";

    public AudioSource AudioSource;
    public AudioSource ClickSound;
    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray();
            RaycastHit hit = new RaycastHit();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //マウスクリックした場所からRayを飛ばし、オブジェクトがあればtrue 
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.CompareTag(cubeTag))
                {
                    hit.collider.gameObject.GetComponent<ObjContro>().OnUserAction();
                }
                if (hit.collider.gameObject.CompareTag("Up"))
                {
                    {
                        AudioSource.volume += 0.1f;
                        ClickSound.Play();
                    }

                }if (hit.collider.gameObject.CompareTag("Down"))
                {
                    {
                        AudioSource.volume -= 0.1f;
                        ClickSound.Play();
                    }

                }
            }
        }
    }
}
