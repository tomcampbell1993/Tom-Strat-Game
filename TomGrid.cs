using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomGrid
{
    private int width;
    private int height;
    private float cellSize;
    private int[,] gridArray;

    public TomGrid(int width, int height, float cellSize)
    {
        this.width = width; // number cells x
        this.height = height; // number cells y
        this.cellSize = cellSize; // distance between cells

        gridArray = new int[width, height];

        //Debug.Log(width + " " + height);

        for(int x = 0; x < gridArray.GetLength(0); x++)
        {
            for(int y = 0; y < gridArray.GetLength(1); y++)
            {
                //Debug.Log(x + " , " + y);
            }
        }
    }

    public int[,] GetGridArray()
    {
        return gridArray;
    }

    public float GetCellSize()
    {
        return cellSize;
    }

}
