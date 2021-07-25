using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayer : Player
{
    RollingDice blueRollingDice;

    private void Start()
    {
        blueRollingDice = GetComponentInParent<BlueHome>().rollingDice;
    }
    public void onClick(){
        
        if(GameManager.gm.rolledDice !=null)
        {
            if(!isReadyToMove)
            {
                if(GameManager.gm.rolledDice == blueRollingDice && GameManager.gm.numberOfStepsToMove == 6)
                {
                    MakePlayerReadyToMove(pathsParent.bluePathPoint);
                    GameManager.gm.numberOfStepsToMove = 0;

                    //Here we will activate the dark transparent background active 

                    return;
                }

            }

            if(GameManager.gm.rolledDice == blueRollingDice && isReadyToMove)
            {
                canMove = true;
            }
        }
        // UpdatecanMove = true;
        moveSteps(pathsParent.bluePathPoint);
    }

}
