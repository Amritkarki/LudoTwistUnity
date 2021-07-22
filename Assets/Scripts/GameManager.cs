using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    private int totalRedAtHome,totalGreenAtHome,totalBlueAtHome,totalYellowAtHome;
    public GameObject redFrame,blueFrame,greenFrame,yellowFrame;


    public GameObject red1Shadow,red2Shadow,red3Shadow,red4Shadow;
    public GameObject green1Shadow,green2Shadow,green3Shadow,green4Shadow;
    public GameObject blue1Shadow,blue2Shadow,blue3Shadow,blue4Shadow;
    public GameObject yellow1Shadow,yellow2Shadow,yellow3Shadow,yellow4Shadow;

    public Vector3 red1Pos,red2Pos,red3Pos,red4Pos;
    public Vector3 blue1Pos,blue2Pos,blue3Pos,blue4Pos;
    public Vector3 green1Pos,green2Pos,green3Pos,green4Pos;
    public Vector3 yellow1Pos,yellow2Pos,yellow3Pos,yellow4Pos;
    

    //---------------------Player Movement-------------------
    public GameObject redPlayer1,redPlayer2,redPlayer3,redPlayer4;
    public GameObject bluePlayer1,bluePlayer2,bluePlayer3,bluePlayer4;
    public GameObject greenPlayer1,greenPlayer2,greenPlayer3,greenPlayer4;
    public GameObject yellowPlayer1,yellowPlayer2,yellowPlayer3,yellowPlayer4;


    //--------------------Players Buttons for on click event-----------------------
    public Button redPlayer1Button,redPlayer2Button,redPlayer3Button,redPlayer4Button;
    public Button greenPlayer1Button,greenPlayer2Button,greenPlayer3Button,greenPlayer4Button;
    public Button bluePlayer1Button,bluePlayer2Button,bluePlayer3Button,bluePlayer4Button;
    public Button yellowPlayer1Button,yellowPlayer2Button,yellowPlayer3Button,yellowPlayer4Button;

    //-------------------------------Players Steps-----------------------------------------
    private int redPlayer1Steps,redPlayer2Steps,redPlayer3Steps,redPlayer4Steps;
    private int bluePlayer1Steps,bluePlayer2Steps,bluePlayer3Steps,bluePlayer4Steps;
    private int greenPlayer1Steps,greenPlayer2Steps,greenPlayer3Steps,greenPlayer4Steps;
    private int yellowPlayer1Steps,yellowPlayer2Steps,yellowPlayer3Steps,yellowPlayer4Steps;

    public GameObject redWinningImage,greenWinningImage,blueWinningImage,yellowWinningImage;

    

    //------------------Dice roll click--------------------------------
    public Transform diceRoll;
    public Button diceRollButton;
    public Transform reddiceRoll,greendiceRoll,bluediceRoll,yellowdiceRoll;

    private int selectDiceNumAnimation;

    public GameObject dice1RollAnnimation,dice2RollAnnimation,dice3RollAnnimation,dice4RollAnnimation,dice5RollAnnimation,dice6RollAnnimation;

    public GameObject redDiceRollBackground,blueDiceRollBackground,greenDiceRollBackground,yellowDiceRollBackground;
    public GameObject diceStarImage,diceBlackBackground,diceIndicatorArrow;




    
    private string playerTurn = "GREEN";
    private string currentPlayer = "none";
    private string currentPlayerName = "GREEN";
    
    public List<GameObject> CommonMovementBlock = new List<GameObject>();
    public List<GameObject> redMovementBlock = new List<GameObject>();
    public List<GameObject> greenMovementBlock = new List<GameObject>();
    public List<GameObject> blueMovementBlock = new List<GameObject>();
    public List<GameObject> yellowMovementBlock = new List<GameObject>();
    
    
    //---------------------Confirmation screen for exiting game
    public GameObject quitGameScreen;
    public GameObject menuScreen;
    //---------------------Game completed modal confirmScreen
    public GameObject gameCompletedScreen;

    private System.Random randNo;
    
    //Normal UI controls
    public GameObject coinsInfo;
    
    // Start is called before the first frame update
    void Start()
    {
        print("GameManager start method called");
        QualitySettings.vSyncCount = 1;
        Application.targetFrameRate = 30;

        randNo = new System.Random();

        dice1RollAnnimation.SetActive(false);
        dice2RollAnnimation.SetActive(false);
        dice3RollAnnimation.SetActive(false);
        dice4RollAnnimation.SetActive(false);
        dice5RollAnnimation.SetActive(false);
        dice6RollAnnimation.SetActive(false);
        
        red1Pos = redPlayer1.transform.position;
        red2Pos = redPlayer2.transform.position;
        red3Pos = redPlayer3.transform.position;
        red4Pos = redPlayer4.transform.position;

        green1Pos = greenPlayer1.transform.position;
        green2Pos = greenPlayer2.transform.position;
        green3Pos = greenPlayer3.transform.position;
        green4Pos = greenPlayer4.transform.position;

        blue1Pos = bluePlayer1.transform.position;
        blue2Pos = bluePlayer2.transform.position;
        blue3Pos = bluePlayer3.transform.position;
        blue4Pos = bluePlayer4.transform.position;

        yellow1Pos = yellowPlayer1.transform.position;
        yellow2Pos = yellowPlayer2.transform.position;
        yellow3Pos = yellowPlayer3.transform.position;
        yellow4Pos = yellowPlayer4.transform.position;

        red1Shadow.SetActive(false);
        red2Shadow.SetActive(false);
        red3Shadow.SetActive(false);
        red4Shadow.SetActive(false);

        green1Shadow.SetActive(true);
        green2Shadow.SetActive(true);
        green3Shadow.SetActive(true);
        green4Shadow.SetActive(true);

        blue1Shadow.SetActive(false);
        blue2Shadow.SetActive(false);
        blue3Shadow.SetActive(false);
        blue4Shadow.SetActive(false);

        yellow1Shadow.SetActive(false);
        yellow2Shadow.SetActive(false);
        yellow3Shadow.SetActive(false);
        yellow4Shadow.SetActive(false);

        redFrame.SetActive(false);
        greenFrame.SetActive(false);
        blueFrame.SetActive(false);
        yellowFrame.SetActive(false);

        switch(MenuManager.numberOfPlayers){
            //case 2:
        };

        //print(MenuManager.numberOfPlayers);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quitGame(){
        SoundManager.buttonAudioSource.Play();
        quitGameScreen.SetActive(true);
    }

    public void quitGameYes(){
        SoundManager.buttonAudioSource.Play();
        SceneManager.LoadScene("MenuScene");
        // if(EditorApplication.isPlaying == true){
        //     EditorApplication.isPlaying = false;
        // }
    }

    public void exitGame(){
        SoundManager.buttonAudioSource.Play();
        SceneManager.LoadScene("MenuScene");
    }

    public void quitGameNo(){
        SoundManager.buttonAudioSource.Play();
        quitGameScreen.SetActive(false); 
    }

    public void menuButtonClick(){
        SoundManager.buttonAudioSource.Play();
        //SceneManager.LoadScene("MenuScene");
        menuScreen.SetActive(true);
    }

    public void closeMenuScreen(){
        SoundManager.buttonAudioSource.Play();
        menuScreen.SetActive(false);
    }

    public void chatButtonClick(){
         SoundManager.buttonAudioSource.Play();
    }

    public void exitApplication(){
        
    }

    public void diceClickRoll(){
        SoundManager.dicerollAudioSource.Play();
        //diceRollButton.interactable = false;
        diceStarImage.SetActive(false);
        dice3RollAnnimation.SetActive(true);
        //redDiceRollBackground.SetActive(true);
        //diceRollButton.interactable = false;

        //diceStarImage.SetActive(false);
        //dice1RollAnnimation.SetActive(true);
        //Debug.Log(randNo);
        selectDiceNumAnimation = randNo.Next(1,7);
        
        
        switch (selectDiceNumAnimation)
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

}
