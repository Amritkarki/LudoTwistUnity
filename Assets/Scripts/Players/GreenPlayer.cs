using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayer : Player
{
    // Start is called before the first frame update
    
    public GameObject test;
    void Start()
    {
        print("Green player start method called");
        //MoveSteps();
        //print(pathObjects.commonPath[4].transform.position);
        //print(test.transform.position);
        //test.SetActive(false);
        //print(pathObjects.commonPath[2].transform.position);
        
        //transform.position = CommonPath.CommonMovementPath[5].transform.position;
        //GameObject.Find("Test").transform.position =
        //var comPath = PathObjects.commonPathPoints.Count();
    }

    void Update(){
        var wola = GameObject.Find("Test").transform.position;
        var dola = transform.position;
        // //print("WOAL:- " + wola);
        //print("DOLA:- " + dola);
        //dola = wola;
    }

    // Update is called once per frame
    public void MoveSteps()
    {
        print("Green player MoveSteps method called");
        for(int i=0;i<5;i++){
            //transform.position = pathObjects.commonPath[i].transform.position;
        }
    }

    IEnumerator MoveStepsEnum(){
        print("Green player IEnumerator function called");
        for(int i=0;i<5;i++){
            //transform.position = pathObjects.commonPath[i].transform.position;
            yield return new WaitForSeconds(1f);
        }

        
    }
}
