using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayer : Player
{
    // Start is called before the first frame update
    
    public void onClick(){
        print(" GreenPlayer Object Clicked: " + this.gameObject.name);
        StartCoroutine("MoveStepsEnum");
    }


    IEnumerator MoveStepsEnum(){
        print("Green player IEnumerator function called");
        for(int i=0;i<5;i++){
            transform.position = pathsParent.commonPathPoints[i].transform.position;
            yield return new WaitForSeconds(.25f);
        }

        
    }
}
