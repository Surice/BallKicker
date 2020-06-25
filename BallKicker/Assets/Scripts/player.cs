using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private int movementSpeed = 80;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("left")){
            transform.position = new Vector3(movementSpeed * Time.deltaTime -1, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.position = new Vector3(movementSpeed * Time.deltaTime +1, 0);
        }
    }
}