using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayer : Player
{
    // Start is called before the first frame update
    
    public void onClick(){
        //print(" GreenPlayer Object Clicked: " + this.gameObject.name);
        canMove = true;
        moveSteps();
    }


}
