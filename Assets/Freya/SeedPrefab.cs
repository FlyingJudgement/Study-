using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class SeedPrefab : MonoBehaviour
{
    public ScriptableSeed scriptableSeed;
    public Color color = Color.green;


    private void OnEnable() => SeedInventory.seedInventory.Add(this);
    
    private void OnDisable() => SeedInventory.seedInventory.Remove(this);
    public MaterialPropertyBlock mpb;
    public MaterialPropertyBlock Mpb{
        get{
            if(mpb == null){
                mpb = new MaterialPropertyBlock();
                return mpb;
            }
        }

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
