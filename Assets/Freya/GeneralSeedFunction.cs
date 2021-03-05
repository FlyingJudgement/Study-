using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteAlways]
public class GeneralSeedFunction : MonoBehaviour
{
    public ScriptableSeed scriptableSeed;


    private void OnEnable() 
    {     
        SeedInventory.seedInventory.Add(this);
    }
    private void OnDisable() 
    {
        SeedInventory.seedInventory.Remove(this);
    }

        
    
    void Start()
    {
        gameObject.name = scriptableSeed.seedName;

     //   SeedInventory.seedInventory.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
