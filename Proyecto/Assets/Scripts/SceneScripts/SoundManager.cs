using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public AudioMixer musicMixer;
    

    
    // Start is called before the first frame update
    public void SetVolume(float volume)
    {
        musicMixer.SetFloat("MusicVolume", volume);
    }

    

    
}
