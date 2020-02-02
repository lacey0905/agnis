using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public static PlayerController instance;

    private void Awake()
    {
        PlayerController.instance = this;
    }


    public void DoAttack(double damage)
    {
        StageController.instance.MonsterDamage(damage);
    }


    public void PlayerLevelUp(int levelUp)
    {
        DataController.instance.PlayerLevel += levelUp;


    }


}
