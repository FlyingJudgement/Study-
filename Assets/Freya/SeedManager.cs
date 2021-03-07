using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedManager : MonoBehaviour
{
    private int seedcount;
    [SerializeField] SeedPrefab generalSeedFunction;
    public ScriptableSeed[] allSeeds; 

private void Start() 
    {
        
        if(seedcount<0){seedcount=0;}
        else if (seedcount<allSeeds.Length){seedcount = allSeeds.Length;}
        foreach(var seed in allSeeds)
        {
             if (seedcount !> allSeeds.Length) 
             {generalSeedFunction.scriptableSeed =
             allSeeds[seedcount];
             seedcount ++;}
        }
    }
}

