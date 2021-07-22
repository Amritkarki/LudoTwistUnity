using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MenuManager : MonoBehaviour
{
    public static int numberOfPlayers;







    public void onLine(){
        SoundManager.buttonAudioSource.Play();
        // numberOfPlayers = 2;
        SceneManager.LoadScene("HomeScene");
    }

    public void multiplayer(){
        SoundManager.buttonAudioSource.Play();
        // numberOfPlayers = 3;
        SceneManager.LoadScene("HomeScene");
    }

    public void privateRoom(){
        SoundManager.buttonAudioSource.Play();
        // numberOfPlayers = 4;
        SceneManager.LoadScene("HomeScene");
    }

    public void computer(){
        SoundManager.buttonAudioSource.Play();
        // numberOfPlayers = 4;
        SceneManager.LoadScene("HomeScene");
    }


    public void quit(){
        SoundManager.buttonAudioSource.Play();
        Application.Quit();
        // if(EditorApplication.isPlaying == true){


        //     EditorApplication.isPlaying = false;
        // }

    }
    
}
