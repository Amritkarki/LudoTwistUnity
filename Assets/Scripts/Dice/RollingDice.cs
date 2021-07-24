using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingDice : MonoBehaviour
{
    
    private bool canDiceRoll = true;
    public int numberGot;
    private System.Random randNo;
    public GameObject diceStarImage,diceBlackBackground,diceIndicatorArrow;
    public GameObject dice1RollAnnimation,dice2RollAnnimation,dice3RollAnnimation,dice4RollAnnimation,dice5RollAnnimation,dice6RollAnnimation;

    Coroutine generateRandomNumberDice_corutine;
    public void onDiceClick()
    {
        generateRandomNumberDice_corutine = StartCoroutine(RandomNumberDiceCorutine());
    }

    IEnumerator RandomNumberDiceCorutine(){

        
        
        yield return new WaitForEndOfFrame();
        if(canDiceRoll){
            SoundManager.dicerollAudioSource.Play();
            canDiceRoll = false;
            randNo = new System.Random();
            numberGot = randNo.Next(1,7);

            GameManager.gm.numberOfStepsToMove = numberGot;
            GameManager.gm.rolledDice = this;

            switch (numberGot)
            {
                case 1:
                    dice1RollAnnimation.SetActive(true);
                    dice2RollAnnimation.SetActive(false);
                    dice3RollAnnimation.SetActive(false);
                    dice4RollAnnimation.SetActive(false);
                    dice5RollAnnimation.SetActive(false);
                    dice6RollAnnimation.SetActive(false);
                    break;
                case 2:
                    dice1RollAnnimation.SetActive(false);
                    dice2RollAnnimation.SetActive(true);
                    dice3RollAnnimation.SetActive(false);
                    dice4RollAnnimation.SetActive(false);
                    dice5RollAnnimation.SetActive(false);
                    dice6RollAnnimation.SetActive(false);
                    break;
                case 3:
                    dice1RollAnnimation.SetActive(false);
                    dice2RollAnnimation.SetActive(false);
                    dice3RollAnnimation.SetActive(true);
                    dice4RollAnnimation.SetActive(false);
                    dice5RollAnnimation.SetActive(false);
                    dice6RollAnnimation.SetActive(false);
                    break;
                case 4:
                    dice1RollAnnimation.SetActive(false);
                    dice2RollAnnimation.SetActive(false);
                    dice3RollAnnimation.SetActive(false);
                    dice4RollAnnimation.SetActive(true);
                    dice5RollAnnimation.SetActive(false);
                    dice6RollAnnimation.SetActive(false);
                    break;
                case 5:
                    dice1RollAnnimation.SetActive(false);
                    dice2RollAnnimation.SetActive(false);
                    dice3RollAnnimation.SetActive(false);
                    dice4RollAnnimation.SetActive(false);
                    dice5RollAnnimation.SetActive(true);
                    dice6RollAnnimation.SetActive(false);
                    break;
                case 6:
                    dice1RollAnnimation.SetActive(false);
                    dice2RollAnnimation.SetActive(false);
                    dice3RollAnnimation.SetActive(false);
                    dice4RollAnnimation.SetActive(false);
                    dice5RollAnnimation.SetActive(false);
                    dice6RollAnnimation.SetActive(true);
                    break;
            }
            
        }
        yield return new WaitForEndOfFrame();
        canDiceRoll = true;


        if(generateRandomNumberDice_corutine != null){
            StopCoroutine(RandomNumberDiceCorutine());
        }


    }
    
}
