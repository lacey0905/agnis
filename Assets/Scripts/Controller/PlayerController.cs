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
        StageController.instance.MonsterDamage(currentDamage);
    }


    public void PlayerLevelUp(int iLevel)
    {
        DataController.instance.PlayerLevel += iLevel;
        DataController.instance.PlayerGold -= GetUpgradeCostByLevel(iLevel);
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
        return 0;
    }

    public double GetUpgradeCostByLevel(int iLevel)
    {
        //double num = (double)Math.Min(ServerVarsModel.tapCostSlowDownLevel, ServerVarsModel.initialPlayerCostOffset + iLevel) * Math.Pow((double)ServerVarsModel.playerUpgradeBase, (double)iLevel);
        //double a = num * (1.0 + PlayerModel.instance.GetStatBonus(BonusType.AllUpgradeCost));
        //return Math.Ceiling(a);
        return 0;
    }

}
