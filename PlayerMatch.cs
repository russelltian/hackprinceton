using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMatch : MonoBehaviour {

    Renderer rend;

    public GameObject joint; //joint
    public bool needMatched;
    Vector3 offset;
    // Use this for initialization
    private bool intersect = false;
    // Update is called once per frame
    private void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {

        if (needMatched)
        {
            //radius of matching part
            Vector3 radius_scale = transform.localScale / 2;
            double radius = radius_scale.magnitude;
            offset = transform.position - joint.transform.position;
            if (offset.magnitude < radius * 2) //make matching easier
            {
                intersect = true;
                rend.material.SetColor("_Color", Color.green);
            }
            else
            {
                intersect = false;
                rend.material.SetColor("_Color", Color.red);
            }

        }else
        {
            rend.material.SetColor("_Color", Color.gray);
        }

        
    }

    public bool getIntersectionStatus()
    {
        if (!needMatched)
        {
            return true;
        }

        return intersect;
    }

    public void setNeedMatchedStatus(bool status)
    {
        needMatched = status;
    }
}
