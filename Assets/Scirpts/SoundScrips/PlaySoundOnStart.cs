using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code taken from youtuber Tarodev: https://www.youtube.com/watch?v=tEsuLTpz_DU&ab_channel=Tarodev
public class PlaySoundOnStart : MonoBehaviour
{
    [SerializeField] private AudioClip _clip; //By having a serialized field here we can apply any audioclip to any prefab we instantiate

    //This method simply plays the assigned soundclip and destroys the prefab some time after it has been spawned
    void Start()
    {
        SoundManager.Instance.PlaySound(_clip);
        Destroy(this.gameObject,2f);    
    }
}
