using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleControl : MonoBehaviour
{

    public GameObject ARSessionToScale;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ScaleUp() 
    {
        Vector3 OScale = ARSessionToScale.transform.localScale;
        Vector3 NScale = OScale * 0.9f;
        ARSessionToScale.transform.localScale = NScale;
    }

    public void ScaleDown()
    {
        Vector3 OScale = ARSessionToScale.transform.localScale;
        Vector3 NScale = OScale * 1.1f;
        ARSessionToScale.transform.localScale = NScale;

    }
}
