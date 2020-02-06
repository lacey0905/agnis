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
        // 현재 레벨
        int currentLV = DataController.instance.PlayerLevel;
        // 업그레이드 가격
        double cost = GetUpgradeCostByLevel(currentLV);
        double nextCost = GetUpgradeCostByLevel(currentLV + 1);
        // 업그레이드 한 데미지
        double damage = GetAttackDamageByLevel(currentLV + 1);
        // 내 골드
        double myGold = DataController.instance.PlayerGold;
        if(myGold >= cost)
        {
            print("UPGRADE!");
            DataController.instance.SetPlayerLevelUp(currentLV + 1, damage, nextCost);
            DataController.instance.PlayerGold -= cost;
        }
    }  

    public void UpdatePlayerStats(bool iNeedToCallDelegate = true)
    {
        //    this.currentDamage = this.GetAttackDamageByLevel(this.playerLevel);
        //    this.nextLevelDMGDiff = this.GetAttackDamageByLevel(this.playerLevel + 1) - this.currentDamage;
        //    this.nextUpgradeCost = this.GetUpgradeCostByLevel(this.playerLevel);
    }

    public double GetAttackDamageByLevel(int iLevel)
    {
        return (double)iLevel * System.Math.Pow((double)1.05f, (double)iLevel);
    }

    public double GetUpgradeCostByLevel(int iLevel)
    {
        double num = (double)Mathf.Min(25, 3 + iLevel) * System.Math.Pow((double)1.074f, iLevel);
        return (double)System.Math.Ceiling(num);
    }

}
