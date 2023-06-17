using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAttack : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] int weaponDamage;
    [SerializeField] float weaponRange;
    [SerializeField] Transform rayOrigin;

    public void Hit()
    {
        RaycastHit HitInfo;

        if (Physics.Raycast(rayOrigin.position, rayOrigin.forward, out HitInfo, weaponRange))
        {
            if (HitInfo.transform.gameObject.GetComponent<Health>())
                HitInfo.transform.gameObject.GetComponent<Health>().GetDamage(weaponDamage);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("isAttackin") ;
        }


        
    }
}
