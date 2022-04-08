using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //Toutes les variables accessibles dans l'inspector
    #region Exposed
    public Sound[] sounds;
    //public static AudioClip shootSound, enemyHitSound, enemyDeathSound, playerHitSound, playerDeathSound, levelCompleteSound;
    #endregion

    #region Unity Life Cycle
    void Awake()
    {
       /* shootSound = ShootingSound.Load<AudioClip>("laser_01");
        audioSource = GetComponent<AudioSource>();*/
       foreach(Sound s in sounds)
        {
            s._audioSource = gameObject.AddComponent<AudioSource>();
            s._audioSource.clip = s.clip;
            s._audioSource.volume = s.volume;
            s._audioSource.pitch = s.pitch;
            s._audioSource.loop = s.loop;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Play("Theme");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
    //Toutes les fonctions créées par l'équipe
    #region Main Methods
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s._audioSource.Play();
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s._audioSource.Stop();
    }
    #endregion

    //Les variables privées et protégées
    #region Private & Protected

    #endregion
}
