using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code taken from youtuber Tarodev: https://www.youtube.com/watch?v=tEsuLTpz_DU&ab_channel=Tarodev
public class ToggleAudio : MonoBehaviour
{
    [SerializeField] private bool _toggleSounds;

    public void Toggle()
    {
        if(_toggleSounds) SoundManager.Instance.ToggleSounds();
    }
}
