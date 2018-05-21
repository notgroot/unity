using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//yo
public class PlayerMovement : MonoBehaviour
{

    private float speed;
    public float axisX;
    public float axisY;

    // Use this for initialization
    void Start()
    {

        speed = 3;

    }

    // Update is called once per frame
    void Update()
    {

        Vertical();

        Horizontal();


        transform.Translate(new Vector3(axisX, axisY) * Time.deltaTime * speed);

    }

    float Vertical()
    {

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            axisY = -1;
            axisX = 0;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            axisY = 1;
            axisX = 0;
        }

        //axisY = Input.GetAxis("Vertical");

        return axisY;
    }

    float Horizontal()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            axisX = -1;
            axisY = 0;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            axisX = 1;
            axisY = 0;
        }

        //axisX = Input.GetAxis("Horizontal");

        return axisX;
    }

}