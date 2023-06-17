using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : MonoBehaviour
{
    [SerializeField] private GameObject startWeapon;
    public GameObject Camera;
    public float distance = 15f;
    GameObject currentWeapon;
    bool canPickUp;
    List<GameObject> Weapons = new List<GameObject> ();


    private void Awake()
    {
        Weapons.Add(startWeapon);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) PickUp();
        if (Input.GetKeyDown(KeyCode.Q)) Drop();
    }
    
    void PickUp()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, distance))
        {
            if (hit.transform.tag == "Weapon")
            {
               
                foreach (var weapon in Weapons)
                {
                    weapon.SetActive(false);   
                }
                Weapons.Add(hit.transform.gameObject);
                currentWeapon = hit.transform.gameObject;
                currentWeapon.GetComponent<Rigidbody>().isKinematic = true;
                currentWeapon.transform.parent = transform;
                currentWeapon.transform.localPosition = Vector3.zero;
                currentWeapon.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
                canPickUp = true;
                
            }
        }
    }

    void Drop()
    {
        currentWeapon.transform.parent = null;
        currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
        canPickUp = false;
        currentWeapon = null;
   
    }
    

}
