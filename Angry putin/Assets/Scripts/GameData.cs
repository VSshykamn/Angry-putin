using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjekts/GameObjekts", order = 1)]
public class GameData : ScriptableObject
{
    private const string OpenLevelsValueName = "OpenLevels";
    [SerializeField] private int openLevels;
    [SerializeField] private int maxLevel = 12;
    public int OpenLevels
    {
        get
        {
            return openLevels;
        }
        set
        {
            if (value <= maxLevel)
            {
                openLevels = value;
            }

        }
    }

    public int MaxLevel
    {
        get
        {
            return maxLevel;
        }

    }

    private void Awake()
    {
        openLevels = LoadData(OpenLevelsValueName);

        if (PlayerPrefs.HasKey(OpenLevelsValueName))
        {
            openLevels = LoadData(OpenLevelsValueName);
        }
        else 
        {
            openLevels = 1;
        }
    }

    public void SaveData(string keyName, int value)
    {
        PlayerPrefs.SetInt(keyName, value);
    }

    public int LoadData(string keyName)
    {
        return PlayerPrefs.GetInt(keyName);
    }

    public void GoToNextLevel() 
    {
        SaveData(OpenLevelsValueName, ++openLevels);   
    }
}

