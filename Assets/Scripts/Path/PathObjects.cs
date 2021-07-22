using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathObjects : MonoBehaviour
{
    public WayPoint[] commonPathPoints;
    public  List<GameObject> CommonMovementPath = new List<GameObject>();
    public WayPoint[] greenPathPoint;
    public WayPoint[] bluePathPoint;
    public WayPoint[] redPathPoint;
    public WayPoint[] yellowPathPoint;


    void Start()
    {
        print("PathObjects start method called");
        //commonPath[5].enabled=false;
        print("PathObjectParent commonPathPoints length: " + commonPathPoints.Length);
        print("PathObjectParent commonPathPoints count: " + CommonMovementPath.Count);
        
    }

}

