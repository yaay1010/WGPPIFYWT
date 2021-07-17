using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoInvisible : MonoBehaviour
{
    // Start is called before the first frame update

    private MeshRenderer meshRenderer;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        GoInvis();
    }

    // Update is called once per frame

    void GoInvis() 
    {
        meshRenderer.enabled = false;
    }
}
