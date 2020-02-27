using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isSmooth;
    [Space]
    private float speed = 5f;
    private float speedSmooth = 10f;
    
    private float _horizontal;
    private float _vertical;

    private float _posX;
    private float _posZ;


    private void Update()
    {
        Movement();
    }
    private void Movement()
    {
        // if (isSmooth)
        // {
        //     _horizontal = Input.GetAxis("Horizontal");
        //     _vertical = Input.GetAxis("Vertical");

        //     _posX = _horizontal * speedSmooth * Time.deltaTime;
        //     _posZ = _vertical * speedSmooth * Time.deltaTime;
        // }

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(_horizontal * speed * Time.deltaTime, 0, _vertical * speed * Time.deltaTime);

}
}
