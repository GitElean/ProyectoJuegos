using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelController : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject gOver;
    public GameObject SC;
    //public GameObject healthCount;
    public GameObject scoreCount;
    bool isPaused = false;
    float finishtime = 5.0f;
    float nextscene = 0.0f;

    public void changeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        ContadorVida.healthvalue = 15;
        ContadorPuntos.scorevalue = 0;
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            TogglePause();

        if (ContadorVida.healthvalue <= 0)
        {
            gameOve();
        }

        if (ContadorPuntos.scorevalue > 30)
        {
            stageClear();
        }
    }

    public void TogglePause()
    {

        isPaused = !isPaused;
        pauseMenu.SetActive(isPaused);

        Time.timeScale = isPaused ? 0.0f : 1.0f;
    }

    public void gameOve()
    {
        
        gOver.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void stageClear()
    {
        SC.SetActive(true);
        nextscene = Time.time + finishtime;
        changeScene("Menu");
    }

}
