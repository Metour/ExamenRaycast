using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Transform groundSensor;
    private Transform hitTag;
    public LayerMask detectLayer;
    
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Input.GetButtonDown("Fire1"))
        {
            if(Physics.Raycast(ray, out hit, detectLayer))
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.green);
                string hitTag = hit.transform.tag;
                string hitName = hit.transform.name;
                
                if(hitTag == "Scene1")
                {
                    SceneManager.LoadScene("Scene1");
                }

                if(hitTag == "Scene2")
                {
                    SceneManager.LoadScene("Scene2");
                }

                if(hitTag == "Scene3")
                {
                    SceneManager.LoadScene("Scene3");
                }
            }
        }
    }
}