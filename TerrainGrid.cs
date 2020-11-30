using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TerrainGrid : BasicGrid
{

    public GameObject floorObject;
    public GameObject wallObject;

    public List<GameObject> terrainList;


    void Start()
    {
        terrainList = new List<GameObject>();

        GridValues();
        GenerateInitialTerrain();
    }

    // Update is called once per frame
    void Update()
    {       
    }

    private void BuildWall(int x, int y)
    {
        GameObject wallInstance = Instantiate(wallObject, new Vector3(x * cellSize, y * cellSize, 1), transform.rotation);
        TestWall wall = wallInstance.GetComponent<TestWall>();
        wall.SetScale(cellSize * 100, 3);
        wall.SetCoords(x*cellSize, y*cellSize);
    }

    private void BuildFloor(int x, int y)
    {
        GameObject floorInstance = Instantiate(floorObject, new Vector3(x * cellSize, y * cellSize, 1), transform.rotation);
        TestFloor floor = floorInstance.GetComponent<TestFloor>();
        floor.SetScale(cellSize * 100, 3);
        floor.SetCoords(x * cellSize, y * cellSize);
    }

    private void GenerateInitialTerrain()
    {
        DisplayGrid displayGrid = GameObject.Find("DisplayGrid").GetComponent<DisplayGrid>();
        List<GameObject> gridlist = displayGrid.GetGridList();

        foreach(GameObject gridObject in gridlist)
        {
            GridBox gridBox = gridObject.GetComponent<GridBox>();

            if(gridBox.GetGridType() == 2)
            {
                BuildWall(gridBox.Getx(), gridBox.Gety());
                terrainList.Add(wallObject);
            }
            if(gridBox.GetGridType() == 1)
            {
                BuildFloor(gridBox.Getx(), gridBox.Gety());
                terrainList.Add(floorObject);
            }
        }
    }

    public List<GameObject> GetTerrainList()
    {
        return terrainList;
    }

}
