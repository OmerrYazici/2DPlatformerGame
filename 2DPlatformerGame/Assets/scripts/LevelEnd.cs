using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public int bolumIndex;
    public bool bir, iki, uc;
    public void bitir()
    {
        bolumIndex++;
        PlayerPrefs.SetInt("bolum", bolumIndex);
        SceneManager.LoadScene("Levels");
    }
    public void restart()
    {
        if(bir)
        {
            SceneManager.LoadScene("Level1");
        }if(iki)
        {
            SceneManager.LoadScene("Level2");
        }if(uc)
        {
            SceneManager.LoadScene("Level3");
        }
        
    }
    public void Menu()
    {
        SceneManager.LoadScene("Levels");
    }
}
