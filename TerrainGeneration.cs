using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneration : MonoBehaviour
{
    public List<IntCoord2> wallCoordList;

    void Start()
    {
        SetLists();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLists()
    {
        wallCoordList = new List<IntCoord2>();

        IntCoord2 a1 = new IntCoord2(1, 2);
        IntCoord2 a2 = new IntCoord2(2, 2);
        IntCoord2 a3 = new IntCoord2(0, 0);

        wallCoordList.Add(a1);
        wallCoordList.Add(a2);
        wallCoordList.Add(a3);
    }

    public List<IntCoord2> GetWallCoordList()
    {
        return wallCoordList;
    }
}
