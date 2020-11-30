using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayGrid : BasicGrid
{
    public GameObject gridBoxObject;
    public List<GameObject> gridList;

    void Start()
    {
        gridList = new List<GameObject>();

        GridValues();
        SetTerrainType();
        gameObject.transform.position = new Vector3(0, 0, 3);
        
    }

    void Update()
    {
        
    }

    public void SetTerrainType() // Initial Grid Generation
    {

        TerrainGeneration terrainGenerator = GameObject.Find("TerrainGenerator").GetComponent<TerrainGeneration>(); //Set Walls

        terrainGenerator.SetLists();
        List<IntCoord2> WallList = terrainGenerator.GetWallCoordList();

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                GameObject gridBoxInstance = Instantiate(gridBoxObject, new Vector3(x * cellSize, y * cellSize, 2), transform.rotation, gameObject.transform);
                GridBox gridBox = gridBoxInstance.GetComponent<GridBox>();
                gridBox.setScale(cellSize * 100);
                gridBox.SetCoord(x, y);

                int rem = ((x + y) % 2);
                if (rem == 0)
                {
                    gridBox.setSprite("red");
                }
                else
                {
                    gridBox.setSprite("blue");
                }

                gridBox.SetGridType(1);

                
                int tempx = -1;
                int tempy = -1;

                foreach(IntCoord2 wallCoord in WallList)
                {
                    tempx = wallCoord.Getx();
                    tempy = wallCoord.Gety();

                    if(tempx == x && tempy == y)
                    {
                        gridBox.SetGridType(2);
                        Debug.Log(x + "," + y + " set to 2");
                    }                   
                    tempx = -1;
                    tempy = -1;
                }

                gridList.Add(gridBoxInstance);
                
            }
        }
    }

    public List<GameObject> GetGridList()
    {
        return gridList;
    }
}
