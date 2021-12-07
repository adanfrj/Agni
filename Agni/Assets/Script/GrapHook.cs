using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapHook : MonoBehaviour
{
    public Camera mainCamera;
    public LineRenderer lineRen;
    public SpringJoint2D joint;

    // Start is called before the first frame update
    void Start()
    {
        joint.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePos = (Vector2)mainCamera.ScreenToWorldPoint(Input.mousePosition);
            lineRen.SetPosition(0, mousePos);
            lineRen.SetPosition(1, transform.position);
            joint.connectedAnchor = mousePos;
            joint.enabled = true;
            lineRen.enabled = true;
        }
        else if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            joint.enabled = false;
            lineRen.enabled = false;
        }
        if (joint.enabled)
        {
            lineRen.SetPosition(1, transform.position);
        }
    }
}
