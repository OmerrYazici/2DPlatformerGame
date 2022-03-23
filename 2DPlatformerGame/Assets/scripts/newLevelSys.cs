using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class newLevelSys : MonoBehaviour
{
    public int bolumIndex;
    public Button bir, iki, uc;
    // Start is called before the first frame update
    void Start()
    {
        bolumIndex = PlayerPrefs.GetInt("bolum");
    }

    // Update is called once per frame
    void Update()
    {
        if (bolumIndex==0)
        {
            bolumIndex = 1;
            iki.interactable = false;
            uc.interactable = false;
            PlayerPrefs.SetInt("bolum", bolumIndex);
        }
        if(bolumIndex==2)
        {
            iki.interactable = true;
        }

        if (bolumIndex == 3)
        {
            iki.interactable = true;
            uc.interactable = true;
        }
    }
    public void bolum1()
    {
        SceneManager.LoadScene("Level1");
    }public void bolum2()
    {
        SceneManager.LoadScene("Level2");
    }public void bolum3()
    {
        SceneManager.LoadScene("Level3");
    }
    public void MainMenus()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Sýfýrla()
    {
        bolumIndex = 0;
        PlayerPrefs.SetInt("bolum", bolumIndex);
    }
}
