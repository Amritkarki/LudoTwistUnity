using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonPath : MonoBehaviour
{
    public  List<GameObject> CommonMovementPath = new List<GameObject>();
    //public PathPoint[] commonPathPoints;
    private int cnt;

    void Start()
    {
        // print("Common Path Group Script");
        // print(CommonMovementPath.Count);
        // cnt = 1;
        // print("Waypoint 5: " + CommonMovementPath[5].transform.position);
        // GameObject.Find("Test").transform.position = CommonMovementPath[5].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
