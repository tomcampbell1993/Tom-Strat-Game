using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGrid : MonoBehaviour
{
    public int gridX;
    public int gridY;
    public int[,] gridArray;
    public float cellSize;

    private void Start()
    {

    }

    public void GridValues() // Set Values for all grids
    {
        gridX = 6;
        gridY = 6;
        cellSize = 1.0f;
        gridArray = new int[gridX, gridY];
    }

    public float GetCellSize()
    {
        return cellSize;
    }

}
