using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Code taken from youtuber Tarodev: https://www.youtube.com/watch?v=tEsuLTpz_DU&ab_channel=Tarodev
public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider _slider; //The VolumeSlider in Settings is dragged into this slot to make use of the slider value

    void Start()
    {
        _slider.value = SoundManager.Instance.GetVolume(); //Sets the volume to the value of the slider immedeatly
        

        // AddListener sets tthe value of the volume to the sliders value when the user interacts with the slider (in the future)
        _slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeMasterVolume(val)); 
    }

}
