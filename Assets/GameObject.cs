using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickPodition = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Vector3 dist = clickPodition - Input.mousePosition;
            Debug.Log(dist);
        }

    }

   


    private Vector3 clickPodition;
}
