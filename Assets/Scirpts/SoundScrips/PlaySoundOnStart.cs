using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code taken from youtuber Tarodev: https://www.youtube.com/watch?v=tEsuLTpz_DU&ab_channel=Tarodev
public class PlaySoundOnStart : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    void Start()
    {
        SoundManager.Instance.PlaySound(_clip);
        Destroy(this.gameObject,2f);    
    }
}
