using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qwerty : MonoBehaviour
{
    private MeshRenderer _mesh;

    private void Awake()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
            {
            _mesh.material.color = Color.green;

        }


    }
}
