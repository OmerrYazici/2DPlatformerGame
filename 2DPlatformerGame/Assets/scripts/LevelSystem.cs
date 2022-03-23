using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSystem : MonoBehaviour
{
    public static bool level1, level2, level3;

    public Button level1_button, level2_button, level3_button;

    private void Start()
    {
        level1 = true;
    }
    private void Update()
    {
        if (level2 == true)
        {
            level2_button.interactable = true;
        }
        if (level3 == true)
        {
            level3_button.interactable = true;
        }
    }
}
