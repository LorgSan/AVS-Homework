using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowTilt : MonoBehaviour
{
    private Vector3 startPos;
    [SerializeField] GameObject cam;
    [SerializeField] float xRotEffect, zRotEffect;

    // Start is called before the first frame update
    void Start()
    {
        startPos.x = transform.eulerAngles.x;
        startPos.z = transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        float xShift = (cam.transform.position.y * xRotEffect);
        float zShift = (cam.transform.position.x * zRotEffect);
        transform.eulerAngles = new Vector3(startPos.x + xShift,transform.eulerAngles.y, startPos.z - zShift); 
        //transform.eulerAngles = new Vector3(transform.position.y,transform.position.y, startPos.z - zShift); 
    }
}
