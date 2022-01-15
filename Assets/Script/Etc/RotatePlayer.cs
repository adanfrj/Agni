using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    public GrapplingHook grappling;
    

    // Update is called once per frame
    void Update()
    {
        if(!grappling.IsGrappling()) return;
        transform.LookAt( worldPosition: grappling.GetGrapplePoint());
    }
}
