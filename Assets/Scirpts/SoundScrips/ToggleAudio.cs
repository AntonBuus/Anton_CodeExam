using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Code taken from youtuber Tarodev: https://www.youtube.com/watch?v=tEsuLTpz_DU&ab_channel=Tarodev
public class ToggleAudio : MonoBehaviour
{
    //Was part of the tutorial but is not needed since there is no music and sounds to distinguish between
    //[SerializeField] private bool _toggleSounds; //Is checked in the unity inspector

    Toggle _toggle; // This variable is declared to be assigned in the start method

    // In start() the _toggle variable is assigned a reference of Toggle on the gameobject
    void Start()
    {
        _toggle = GetComponent<Toggle>();
        _toggle.isOn = !SoundManager.Instance._isMuted;
    }
    // This method calls the ToggleSounds method from the Soundmanager
    public void Toggle()
    {
        //if(_toggleSounds) //not needed here
        SoundManager.Instance.ToggleSounds(!_toggle.isOn);
    }
}
