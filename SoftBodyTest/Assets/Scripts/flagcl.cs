using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagcl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Cloth>().stretchingStiffness = 0.8f;
        gameObject.GetComponent<Cloth>().bendingStiffness = 0.8f;
        gameObject.GetComponent<Cloth>().clothSolverFrequency = 1000;
        gameObject.GetComponent<Cloth>().damping = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
