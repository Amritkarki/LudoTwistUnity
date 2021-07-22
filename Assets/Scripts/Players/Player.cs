using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public bool moveNow;
   public int stepToMove;

   public PathObjects pathObjects;

   private void awake()
   {
       //print("Parent player awake method called");
       pathObjects = FindObjectOfType<PathObjects>();
   }
}
