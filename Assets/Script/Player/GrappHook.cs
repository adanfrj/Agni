using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappHook : MonoBehaviour
{
    public Camera mainCamera;
    public LineRenderer lineren;
    public DistanceJoint2D distanceJoint;


    // Start is called before the first frame update
    void Start()
    {
        distanceJoint.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            lineren.SetPosition(0, mousePos);
            lineren.SetPosition(1, transform.position);
            distanceJoint.connectedAnchor = mousePos;
            distanceJoint.enabled = true;
            lineren.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            distanceJoint.enabled=false;
            lineren.enabled = false;
        }

        if (distanceJoint.enabled)
        {
            lineren.SetPosition(1, transform.position);
        }
    }
}
