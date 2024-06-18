using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class switchRail : MonoBehaviour
{

    GameObject xrRig;
    Mover mover;

    // Start is called before the first frame update
    void Awake()
    {
        xrRig = GameObject.Find("XR Rig");
        mover = xrRig.GetComponent<Mover>();
        mover.rail = GameObject.Find("railNode").GetComponent<Rail>();

    }

    // Update is called once per frame
    void Update()
    {
        if(mover.isPaused == true) 
        {
            mover.rail = GameObject.Find("RailNodeV2").GetComponent<Rail>();
            mover.setTransition(0);
        }
    }
}
