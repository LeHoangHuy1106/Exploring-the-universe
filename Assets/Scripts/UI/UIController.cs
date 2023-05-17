using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject panelStore, panelPause, panelGameOver;


    private void Start()
    {
        if (panelStore)
        {
            panelStore.SetActive(false);
            panelPause.SetActive(false);
            panelGameOver.SetActive(false);
        }
    }


    public void isPanelStore()
    {
        panelPause.SetActive(false);

        panelStore.SetActive(!panelStore.activeInHierarchy);
        if (panelStore.activeInHierarchy)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void isPanelPause()
    {
        panelStore.SetActive(false);
        panelPause.SetActive(!panelPause.activeInHierarchy);
        if(panelPause.activeInHierarchy)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }

    }

 
    public void IsResetGame()
    {
      //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);

           Application.LoadLevel("Game play");
   
        panelPause.SetActive(false);
        Time.timeScale = 1;

    }
   
    public void IsBackGame()
    {
        Time.timeScale = 1;
        Application.LoadLevel("OpenScene");
     
    }
    public void IsPlayGame()
    {
        Application.LoadLevel("Game play");

    }
    public void IsQuitGame()
    {
        Application.Quit();

    }
}
