using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    public AudioClip buttonAudioClip;
    public AudioClip dismissalAudioClip;
    public AudioClip dicerollAudioClip;
    public AudioClip playerWinAudioClip;
    public AudioClip safeHouseAudioClip;
    public AudioClip playerAudioClip;


    public static AudioSource buttonAudioSource;
    public static AudioSource dismissalAudioSource;
    public static AudioSource dicerollAudioSource;
    public static AudioSource playerWinAudioSource;
    public static AudioSource safeHouseAudioSource;
    public static AudioSource playerAudioSource;


    AudioSource AddAudio(AudioClip clip,bool playOnAwake,bool loop,float volume){

        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.playOnAwake = playOnAwake;
        audioSource.loop = loop;
        audioSource.volume = volume;
        return audioSource;
    }






    // Start is called before the first frame update
    void Start()
    {
        buttonAudioSource = AddAudio(buttonAudioClip,false,false,1.0f);
        dismissalAudioSource = AddAudio(dismissalAudioClip,false,false,1.0f);
        dicerollAudioSource = AddAudio(dicerollAudioClip,false,false,1.0f);
        playerWinAudioSource = AddAudio(playerWinAudioClip,false,false,1.0f);
        safeHouseAudioSource = AddAudio(safeHouseAudioClip,false,false,1.0f);
        playerAudioSource = AddAudio(playerAudioClip,false,false,1.0f);
    }

   
}
