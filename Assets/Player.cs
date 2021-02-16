using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] MonoBehaviour activeGun = null;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireWeapon();
        }
    }

    private void FireWeapon()
    {
        if (activeGun is IGun)
        {
            (activeGun as IGun).Fire();
        }
    }
}
