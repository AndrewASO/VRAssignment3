using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMaterial : MonoBehaviour
{
    public Material[] materials;

    private int currentIndex = 0;
    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void UpdateMaterial(Material newMat)
    {
        GetComponent<MeshRenderer>().material = newMat;
    }

    public void NextMaterial()
    {
        if (materials.Length == 0) return;

        currentIndex++;

        if (currentIndex >= materials.Length)
        {
            currentIndex = 0;
        }

        meshRenderer.material = materials[currentIndex];
    }

    public void PreviousMaterial()
    {
        if (materials.Length == 0) return;

        currentIndex--;

        if (currentIndex < 0)
        {
            currentIndex = materials.Length - 1;
        }

        meshRenderer.material = materials[currentIndex];
    }
}