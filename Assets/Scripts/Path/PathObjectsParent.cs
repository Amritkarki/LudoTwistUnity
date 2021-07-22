using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathObjectsParent : MonoBehaviour
{

    public WayPoint[] commonPathPoints;
    public  List<GameObject> commonMovementPath = new List<GameObject>();
    public WayPoint[] greenPathPoint;
    public WayPoint[] bluePathPoint;
    public WayPoint[] redPathPoint;
    public WayPoint[] yellowPathPoint;



    // Start is called before the first frame update
    void Start()
    {
        // print("PathObjectParent commonPathPoints length: " + commonPathPoints.Length);
        // print("PathObjectParent greenPathPoint length: " + greenPathPoint.Length);
        // print("PathObjectParent bluePathPoint length: " + bluePathPoint.Length);
        // print("PathObjectParent redPathPoint length: " + redPathPoint.Length);
        // print("PathObjectParent yellowPathPoint length: " + yellowPathPoint.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
