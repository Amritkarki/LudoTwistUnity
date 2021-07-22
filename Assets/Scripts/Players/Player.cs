using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool canMove;
    public bool moveNow;
    public int stepToMove;

    //public PathObjects pathObjects;
    public PathObjectsParent pathsParent;

    void Start()
    {
        //print("Player script Start methodstarted");
        
    }

   void Awake()
   {
        //print("Player script Awake methodstarted");
        pathsParent = FindObjectOfType<PathObjectsParent>();
    //    print(pathsParent);
   }
}
