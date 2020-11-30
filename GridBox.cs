using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GridBox : MonoBehaviour
{

    private SpriteRenderer spriteR;

    public Sprite redSprite;
    public Sprite blueSprite;

    public IntCoord2 Coord;

    public int gridType; // number represents what is on top
    // 0 is nothing
    // 1 is Floor
    // 2 is Wall

    private void Awake()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSprite(string colour)
    {
        if (colour == "blue")
        {
            spriteR.sprite = blueSprite;
        }

        if(colour == "red")
        {
            spriteR.sprite = redSprite;
        }

    }

    public void setScale(float scale)
    {
        gameObject.transform.localScale = new Vector3(scale, scale, 1);
    }

    public int GetGridType()
    {
        return gridType;
    }

    public void SetGridType(int x)
    {
        gridType = x;
    }

    public void SetCoord(int x, int y)
    {
        Coord = new IntCoord2(x, y);
    }

    public IntCoord2 GetCoords()
    {
        return Coord;
    }
     public int Getx()
    {
        return Coord.Getx();
    }

    public int Gety()
    {
        return Coord.Gety();
    }
}
