using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Mainmenu : MonoBehaviour
{
    
    //menu principal
    public void changeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    /*public void PlaySFX()
    {
        
    }*/
    //menu de opciones


}
