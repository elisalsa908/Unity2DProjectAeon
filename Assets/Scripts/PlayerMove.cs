using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _walkSpeed = 0;
    [SerializeField] private float _runSpeed = 0;
    [SerializeField] private float _crouchSpeed = 0;
    [SerializeField] private Vector3 direction;
    //Vector3 is a *struct* - a variable which hold other variables 
    //driection.x, direction.y, direction.z

    private void Update()
    {
        //Call the Move method
        Move();
        #region Movement Input
        //if (Input.GetKey(KeyCode.A))
        //{
        //    //transform.position += Vector3.left * Time.deltaTime; 
        //    horizontal--;
        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    //transform.position += Vector3.right * Time.deltaTime; 
        //    horizontal++;
        //}

        //if (Input.GetKey(KeyCode.W))
        //{
        //    //transform.position += Vector3.forward * Time.deltaTime; //same as (0,0,1)
        //    vertical++;
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    //transform.position += Vector3.back * Time.deltaTime;
        //    vertical--;
        //}
        #endregion
    }

    private void Move()
    {
        //Set our direction based on the players inputs using left/right and forward/back axis)
        direction.x = Input.GetAxis("Horizontal"); //sam as horizontal variable
        direction.z = Input.GetAxis("Vertical");

        // run the GetSpeed Meothod and set speed to equal the result
        //float speed = GetSpeed();

        //add our direction times our speed and deltaTime, to our current position
        transform.position += direction * GetSpeed() * Time.deltaTime;
    }

    private float GetSpeed()
    {
        //Get a local float and set it to default walk speed
        float speed = _walkSpeed;

        //if the player is sprinting or crounching, chang the local float
        if (Input.GetKey(KeyCode.LeftShift))
            speed = _runSpeed;
        if (Input.GetKey(KeyCode.LeftControl))
            speed = _crouchSpeed;


        // Returnthe value of that float( it will eqal walkSpeed, runSpeed, r crounchSpeed)
        return speed;
    }



}
