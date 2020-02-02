using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIController : MonoBehaviour
{

    public static GameUIController instance;

    private void Awake()
    {
        GameUIController.instance = this;
    }

    public int LevelUpMultiple { get; set; }

    public void PlayerLevelUp()
    {
        PlayerController.instance.PlayerLevelUp(LevelUpMultiple);
    }


}
