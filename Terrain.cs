using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain : MonoBehaviour
{
    public float xCoord;
    public float yCoord;

    public float toTarget;
    public float toOrigin;
    public float travelValue;

    public GameObject selectedObject;
    public GameObject travelValueTextObject;
    public GameObject UIParent;

    // Start is called before the first frame update
    void Start()
    {
        SetStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCoords(float x, float y)
    {
        xCoord = x;
        yCoord = y;

    }

    public float GetXCoord()
    {
        return xCoord;
    }

    public float GetYCoord()
    {
        return yCoord;
    }

    public void SetScale(float scale, int z)
    {
        gameObject.transform.localScale = new Vector3(scale, scale, z);
    }

    public void TerrainMove(GameObject movingObject) // old movement
    {
        TestGuy testGuy = selectedObject.GetComponent<TestGuy>();
        testGuy.SetTarget(xCoord, yCoord);
        testGuy.SetIsMoving(true);
    }

    public void TerrainPathfind(GameObject movingObject)
    {
        TestGuy testGuy = selectedObject.GetComponent<TestGuy>();
        testGuy.SetFinalTarget(xCoord, yCoord);
        testGuy.CalcualteWayPointDistances();
    }

    public void SetStart()
    {
        selectedObject = GameObject.Find("TestGuy");
        UIParent = GameObject.Find("TomUI");
        toOrigin = 0;
        toTarget = 0;
    }

    public void DisplayTravelValue()
    {       

        GameObject textInstance = Instantiate(travelValueTextObject, gameObject.transform.position, gameObject.transform.rotation,UIParent.transform);
        TravelValueText travelValueText = textInstance.GetComponent<TravelValueText>();
        travelValueText.TravelValueToText(travelValue);
    }

    public float GetToOrigin()
    {
        return toOrigin;
    }

    public float GetToTarget()
    {
        return toTarget;
    }

    public void SetToOrigin(float origin)
    {
        toOrigin = origin;
    }

    public void SetToTarget(float target)
    {
        toTarget = target;
    }

    public void CalucluateTravelValue()
    {
        travelValue = toOrigin + toTarget;
    }

    public float GetTravelValue()
    {
        return travelValue;
    }

}
