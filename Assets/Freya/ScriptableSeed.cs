using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "ScriptableSeed" ,menuName = "ScriptableSeed") ]
public class ScriptableSeed : ScriptableObject
{
    public string seedName;

    public AudioClip seedlingSound;

    public Sprite UIseed; 

    public Mesh seedPickup;

}
