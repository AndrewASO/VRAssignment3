using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class is part of an example of how you can use UnityEvents with
// basic MonoBehaviors to rapidly develop VR interactions.
//
// See: GazeOverEvent.cs
public class SetMaterial : MonoBehaviour
{
    public void UpdateMaterial(Material newMat)
    {
        GetComponent<MeshRenderer>().material = newMat;
    }
}
