using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isSmooth;
    [Space]
    private float speed = 5f;
    private float speedSmooth = 10f;
    
    private float _moveHorizontal;
    private float _moveVertical;

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
        //     _moveHorizontal = Input.GetAxis("Horizontal");
        //     _moveVertical = Input.GetAxis("Vertical");

        //     _posX = _moveHorizontal * speedSmooth * Time.deltaTime;
        //     _posZ = _moveVertical * speedSmooth * Time.deltaTime;
        // }

        _moveHorizontal = Input.GetAxis("Horizontal");
        _moveVertical = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(_moveHorizontal * speed * Time.deltaTime, 0, _moveVertical * speed * Time.deltaTime);

    }
}
