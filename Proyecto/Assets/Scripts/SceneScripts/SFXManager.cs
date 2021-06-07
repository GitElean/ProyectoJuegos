using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFXManager : MonoBehaviour
{
    public AudioMixer SFXMixer;
    public AudioSource audio2;
    //menu principal
    void Start()
    {
        audio2 = GetComponent<AudioSource>();
    }

    public void SetVFX(float volume)
    {
        SFXMixer.SetFloat("SFXVolume", volume);
    }
    public void SFXsound() {
        audio2.Play();
    }

}
