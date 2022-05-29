using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code taken from youtuber Tarodev: https://www.youtube.com/watch?v=tEsuLTpz_DU&ab_channel=Tarodev
public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance; //Creates instance of the this class

   [SerializeField] private AudioSource _soundSource; //This is where the gameoject with an audiosource has to be placed in order for sound to be played
   public bool _isMuted; // This is to acces the mute property without giving other scripts access to the audiosource
    
  /// <summary>
  /// This method is in short the Singleton that persists through scenechanges so that the soundmanager works at all times.
  /// If there is no instance, this gameobject becomes the instance and persists though scenechanges. If there is an instance, it will be destroyed.
  /// </summary>
   void Awake() 
   {
       if (Instance == null) 
       {
           Instance = this;
           DontDestroyOnLoad(gameObject);
       }
       else
       {
           Destroy(gameObject);
       }
    }
    
    // This method is called in the script PlaySoundOnStart. It takes an Audioclip as an argument which is played once when the method is called.
    public void PlaySound(AudioClip clip)
    {
        _soundSource.PlayOneShot(clip);
    }

    // This method is called in the script VolumeSlider. It takes a float as an argument in order for the value to feel more fluid.
    // The method sets the audiolisteners volume equal to the value which is used in the the VolumeSlider.
    public void ChangeMasterVolume(float value)
    {
        AudioListener.volume = value;
    }
    // This method returns the value of the audiolisteners volume as a float to be used in VolumeSlider
    public float GetVolume()
    {
        return AudioListener.volume;
    }

    // This method toggles sounds on and off when called in the Script ToggleAudio.
    public void ToggleSounds(bool _mute)
    {
        _soundSource.mute = _mute;  //this is the line that actually mutes the sounds
        _isMuted = _mute; //this variable is keept up to date across all scenes because of this line and the singleton
    }
}


    ///
///    OLD CODE BELOW, USED TO REQUIRE MULTIPLE METHODS FOR EACH INDIVIDUAL CLIP
/// 
    //    [SerializeField] private AudioSource _adgangSource, _begrænsetSource, _ingenSource;

    // public void PlayAdgangSound()
    // {
    //     _adgangSource.Play();
    // }
    //  public void PlayBegrænsetSound()
    // {
    //     _begrænsetSource.Play();
    // }
    //  public void PlayIngenSound()
    // {
    //     _ingenSource.Play();
    // }

   
    // public void ToggleAdgang()
    // {
    //     _adgangSource.mute = !_adgangSource.mute;
    // }

    // public void ToggleBegrænset()
    // {
    //     _begrænsetSource.mute = !_begrænsetSource.mute;
    // }

    // public void ToggleIngen()
    // {
    //     _ingenSource.mute = !_ingenSource.mute;
    // }