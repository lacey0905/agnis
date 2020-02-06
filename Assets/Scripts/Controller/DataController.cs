using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataController : MonoBehaviour
{

    public static DataController instance;

    public Text gold;
    public Text level;
    public Text wave;
    public Text stage;

    private double playGold;
    private int playerLevel;
    private int currentWave;
    private int currentStage;

    public double PlayerGold {
        get { return playGold; }
        set {
            playGold = value;
            gold.text = "Gold : " + playGold.ToString();
        }
    }
    public int PlayerLevel {
        get { return playerLevel; }
    }

    public void SetPlayerLevelUp(int iLevel, double damage, double cost)
    {
        playerLevel = iLevel;
        level.text = "Cost : " + cost.ToString() + "\n";
        level.text += "DMG : " + damage.ToString() + "\n";
        level.text += "LV : " + playerLevel.ToString() + " +1";
    }

    public int CurrentWave {
        get { return currentWave; }
        set
        {
            currentWave = value;
            wave.text = currentWave.ToString() + " / 10";
        }
    }
    public int CurrentStage {
        get { return currentStage; }
        set
        {
            currentStage = value;
            stage.text = "Stage : " + currentStage.ToString();
        }
    }
    private void Awake()
    {
        DataController.instance = this;

        PlayerGold = 3000d;
        playerLevel = 1;
        CurrentWave = 1;
        CurrentStage = 1;
    }

}
