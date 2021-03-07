using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

#endif
public class SeedInventory : MonoBehaviour
{
    public static List<SeedPrefab> seedInventory = new List<SeedPrefab>();

    #if UNITY_EDITOR
    private void OnDrawGizmos() {
        foreach (SeedPrefab seed in seedInventory)
        {
            Vector3 inventoryPos = transform.position;
            Vector3 seedPos = seed.transform.position;
            float halfHeight = (inventoryPos.y - seedPos.y) * .5f;
            Vector3 halfHeightVector = Vector3.up * halfHeight;  

            Handles.DrawBezier(
             inventoryPos,seedPos,
             inventoryPos - halfHeightVector, seedPos + halfHeightVector,
            Color.magenta,
             EditorGUIUtility.whiteTexture, 2f);
            
        }    
    }
    #endif
}
