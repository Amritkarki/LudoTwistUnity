using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool canMove;
    public bool moveNow;
    public int stepsToMove;

    public int stepsAlreadyMoved;

    //public PathObjects pathObjects;
    public PathObjectsParent pathsParent;
    Coroutine moveStep_Corutine;
   void Awake()
   {
        pathsParent = FindObjectOfType<PathObjectsParent>();
   }


    public void moveSteps(){
        moveStep_Corutine = StartCoroutine(MoveStepsEnum());
    }

   IEnumerator MoveStepsEnum(){

        yield return new WaitForSeconds(.20f);
        
        int numberOfStepsToMove = GameManager.gm.numberOfStepsToMove;
        
        
        if(canMove){
            for(int i = stepsAlreadyMoved; i < (stepsAlreadyMoved + numberOfStepsToMove); i++){
                SoundManager.playerAudioSource.Play();
                transform.position = pathsParent.commonPathPoints[i].transform.position;
                yield return new WaitForSeconds(.25f);
            }
        }

        stepsAlreadyMoved += numberOfStepsToMove;
        
        if(moveStep_Corutine != null)
        {
            StopCoroutine(MoveStepsEnum());
        }

        
    }

}
