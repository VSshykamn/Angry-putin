using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameData gameData;

    private void Awake()
    {
        ActivateLevelsButtons();
    }

    public void ActivateLevelsButtons() 
    {
        for (int i = 0; i < gameData.MaxLevel; i++)//7 levels
        {
            if (i < gameData.OpenLevels)
            {
                transform.GetChild(i).GetComponent<Button>().interactable = true;
            }
            else
            {
                transform.GetChild(i).GetComponent<Button>().interactable = false;
            }
        }
    }

    public void LoadLevel(int levelindex)
    {
        SceneManager.LoadScene(levelindex);
    }



}
