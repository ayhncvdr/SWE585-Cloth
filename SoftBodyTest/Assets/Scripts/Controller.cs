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

        //gameObject.GetComponent<Cloth>().clothSolverFrequency = 300;
        gameObject.GetComponent<Cloth>().stretchingStiffness = 1;


    }
    // Update is called once per frame
    void Update()
    {
    
    }



   


}
