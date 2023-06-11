using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Light light1;


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            light1.enabled = !light1.enabled;



    }
}
