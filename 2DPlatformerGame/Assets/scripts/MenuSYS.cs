using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSYS : MonoBehaviour
{
    public GameObject secenekler, anaMenu;
    public int index;
    public void Secenek()
    {
        anaMenu.SetActive(false);
        secenekler.SetActive(true);
    }
    public void Geri()
    {
        anaMenu.SetActive(true);
        secenekler.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Sýfýrla()
    {
        index = 0;
        PlayerPrefs.SetInt("bolum", index);
        SceneManager.LoadScene("Menu");
    }
}
