using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code taken from youtuber Tarodev: https://www.youtube.com/watch?v=tEsuLTpz_DU&ab_channel=Tarodev
public class ToggleAudio : MonoBehaviour
{
    //Was part of the tutorial but is not needed since there is no music and sounds to distinguish between
    //[SerializeField] private bool _toggleSounds; //Is checked in the unity inspector

    // This method calls the ToggleSounds method from the Soundmanager
    public void Toggle()
    {
        //if(_toggleSounds) //not needed here
        SoundManager.Instance.ToggleSounds();
    }
}
