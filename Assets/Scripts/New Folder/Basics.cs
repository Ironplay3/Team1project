using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{
    public GameObject[] objts = new GameObject[3];

    public Transform target;

    public Light _light;

    public Transform[] transforms = new Transform[3];

    public float speed = 5.0f;

    public float rotateSpeed = 10.0f;
    private void Start()
    { 
        //obj.SetActive(false);
        // obj.GetComponent<Transform>().position = new Vector3 (10,5,8);
        //_light .intensity = 0.5f;   
        //for(int i = 0;i< objts.Length; i++)
        //objts[i].SetActive(false);S
        
        
    }
    private void Update()
    {
        for (int i = 0; i < transforms.Length; i++) {
        
            if (transforms[i] == null) {
                continue;
            }
            transforms[i].Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime );
            transforms[i].Rotate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);

            float posX = transforms[i].position.x;  
            if(posX < -10  && transforms[i].gameObject.name == "Cube" )
                Destroy(transforms[i].gameObject); 

        }


    }

}
