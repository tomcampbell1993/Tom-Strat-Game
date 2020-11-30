using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGuy : MonoBehaviour
{

    public float speed;
    public float cellSize;
    public Vector3 target;
    public Vector3 finalTarget;
    public bool isMoving;

    public GameObject[] terrainArray;
    public GameObject[] WaypointArray;
    public GameObject startPoint;
    public GameObject finalPoint;

    // Start is called before the first frame update
    void Start()
    {
        BasicGrid grid = GameObject.Find("BasicGrid").GetComponent<BasicGrid>();
        grid.GridValues();
        cellSize = grid.GetCellSize();
        isMoving = false;
        speed = 3.0f;
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GridMovement();
    }

    public void GridMovement() // Old Movement
    {
        if(isMoving == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }

        if(transform.position == target)
        {
            isMoving = false;
        }
    }

    public void SetTarget(float x, float y)
    {
        Vector3 newTarget = new Vector3(x, y, 0);
        target = newTarget;
    }

    public void SetFinalTarget(float x, float y)
    {
        Vector3 newTarget = new Vector3(x, y, 0);
        finalTarget = newTarget;
    }

    public void SetIsMoving(bool moving)
    {
        isMoving = moving;
    }

    public void CalcualteWayPointDistances()
    {
        GameObject[] textObjects = GameObject.FindGameObjectsWithTag("TEMPTEXT");
        foreach (GameObject textobject in textObjects)
        {
            Destroy(textobject);
        }

        TerrainGrid terrainGrid = GameObject.Find("TerrainGrid").GetComponent<TerrainGrid>();

        terrainArray = GameObject.FindGameObjectsWithTag("TERRAIN");

        foreach (GameObject terrainObject in terrainArray)
        {
            float distance = Vector2.Distance(terrainObject.transform.position, gameObject.transform.position);
            Terrain terrain = terrainObject.GetComponent<Terrain>();

            terrain.SetToOrigin(distance);

            distance = Vector2.Distance(terrainObject.transform.position, finalTarget);

            terrain.SetToTarget(distance);
            terrain.CalucluateTravelValue();
            terrain.DisplayTravelValue();

        }       
    }

    public void CreateWayPoints()
    {
        GameObject currentPoint = startPoint;

        while(currentPoint != finalPoint)
        {

        }
    }

    public void SetStartPoint(GameObject waypoint)
    {
        startPoint = waypoint;
    }

    public void SetFinalPoint(GameObject waypoint)
    {
        finalPoint = waypoint;
    }

 
    
}
