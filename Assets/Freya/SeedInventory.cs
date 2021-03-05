using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedInventory : MonoBehaviour
{
    public static List<GeneralSeedFunction> seedInventory = new List<GeneralSeedFunction>();

    
    private void OnDrawGizmos() {
        foreach (GeneralSeedFunction seed in seedInventory)
        {
            Gizmos.DrawLine(transform.position, seed.transform.position);    
            
        }    
    }
}
