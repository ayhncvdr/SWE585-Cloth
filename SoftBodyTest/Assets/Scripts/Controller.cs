using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Controller : MonoBehaviour
{



   


    // Start is called before the first frame update
    void Start()
    {

        _updateSolverFrequency();
       

    }


    void _updateSolverFrequency ()
    {

        gameObject.GetComponent<Cloth>().clothSolverFrequency = 120;
        gameObject.GetComponent<Cloth>().stretchingStiffness = 0.2f;
        gameObject.GetComponent<Cloth>().stretchingStiffness = 0.2f;
        gameObject.GetComponent<Cloth>().damping = 0;


    }
    // Update is called once per frame
    void Update()
    {
    
    }



   


}
