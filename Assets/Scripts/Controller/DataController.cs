using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{

    public static DataController instance;

    private void Awake()
    {
        DataController.instance = this;
    }

    public double PlayerGold { get; set; }
    public int PlayerLevel { get; set; }

    public int CurrentWave { get; set; }
    public int CurrentStage { get; set; }


}
