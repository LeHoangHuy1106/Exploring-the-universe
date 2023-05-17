using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;

    [SerializeField]
    private AudioSource[] audiOEffect;

    [SerializeField]
    private AudioClip soundRock, soundGun1, soundGun2, soundButton, soundBoom, soundGameOver, soundEnemy,soundOpen ;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }












    
}
