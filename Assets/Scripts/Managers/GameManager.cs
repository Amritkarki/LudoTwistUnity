using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager gm;

    public int numberOfStepsToMove;

    public RollingDice rolledDice;

    private void Awake()
    {
        gm = this;
    }
}
