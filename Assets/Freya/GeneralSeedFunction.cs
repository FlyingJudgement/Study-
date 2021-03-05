using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralSeedFunction : MonoBehaviour
{
    public ScriptableSeed scriptableSeed;


    private void OnEnable() { 
        
    }
    void Start()
    {
        gameObject.name = scriptableSeed.seedName;

        SeedInventory.seedInventory.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
