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


    public void DoAttack(Vector3 touchPosition)
    {
        double currentDamage = this.GetAttackDamageByLevel(DataController.instance.PlayerLevel);
        StageController.instance.MonsterDamage(currentDamage * 10d);
    }


    public void PlayerLevelUp(int iLevel)
    {
        double cost = GetUpgradeCostByLevel(iLevel);
        double myGold = DataController.instance.PlayerGold;
        if(myGold >= cost)
        {
            DataController.instance.PlayerLevel += iLevel;
            DataController.instance.PlayerGold -= GetUpgradeCostByLevel(iLevel);
        }
    }

    public void UpdatePlayerStats(bool iNeedToCallDelegate = true)
    {
        //    this.currentDamage = this.GetAttackDamageByLevel(this.playerLevel);
        //    this.nextLevelDMGDiff = this.GetAttackDamageByLevel(this.playerLevel + 1) - this.currentDamage;
        //    this.nextUpgradeCost = this.GetUpgradeCostByLevel(this.playerLevel);
    }

    // 레벨업 할 때 얻는 데미지
    private double GetAttackDamageByLevel(int iLevel)
    {
        return (double)iLevel * System.Math.Pow((double)1.05f, (double)iLevel);
    }

    public double GetUpgradeCostByLevel(int iLevel)
    {
        double num = (double)Mathf.Min(25, 3 + iLevel) * System.Math.Pow((double)1.074f, iLevel);
        return (double)System.Math.Ceiling(num);
    }

}
