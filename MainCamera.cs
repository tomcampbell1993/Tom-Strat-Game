using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    public GameObject displayGrid;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        displayGrid = GameObject.Find("DisplayGrid");
        speed = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        ToggleDisplayGrid();
    }

    void Movement()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    void ToggleDisplayGrid()
    {
        if (Input.GetKeyDown("x"))
        {
            if (displayGrid.activeSelf)
            {
                displayGrid.SetActive(false);
            }
            else
            {
                displayGrid.SetActive(true);
            }
        }
    }
}
