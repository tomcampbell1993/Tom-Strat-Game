using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFloor : Terrain
{
    // Start is called before the first frame update
    private void Awake()
    {
        //Debug.Log("Floor at: " + xCoord + "," + yCoord);
        SetStart();
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        TerrainMove(selectedObject);
        TerrainPathfind(selectedObject);
        Debug.Log("Floor clicked at " + xCoord + "," + yCoord);
    }
}
