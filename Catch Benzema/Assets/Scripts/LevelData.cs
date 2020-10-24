using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelData : MonoBehaviour
{

    private int level=1;

    private void Awake()
    {
        level = PlayerPrefs.GetInt("Level");
    }

    public void nextlevel()
    {
        if (level < 100)
            level++;
        PlayerPrefs.SetInt("Level", level);
    }

    public void restartlevels()
    {
        level = 0;
        PlayerPrefs.SetInt("Level", level);

    }

    public int getlevel()
    {
        return level;
    }
}
