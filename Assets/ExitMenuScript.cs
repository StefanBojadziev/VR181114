using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenuScript : MonoBehaviour
{
    //funkcija za start na igrata | game start function
    public void PlayTheGameAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    //funkcija za kraj na igrata | game exit function
    public void QuitTheGame()
    {
        Debug.Log("Igrata se isklucuva / The gaime is quiting!");
        Application.Quit();
    }
}
