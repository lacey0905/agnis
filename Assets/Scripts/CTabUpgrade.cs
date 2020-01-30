using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CTabUpgrade : MonoBehaviour
{

    private float upgradeCost;
    private int upgradeMultiple;

    public Text UIUpgradeCost;

    // 다음 레벨 UI 표시

    private void Start()
    {
        int currentTapLevel = CDataManager.instance.GetMyTapUpgradeLevel();
        upgradeCost = currentTapLevel * 3.14f;
        UIUpgradeCost.text = upgradeCost + "";
    }

    public void Upgrade()
    {
        double myGold = CDataManager.instance.GetMyGold();

        if (upgradeCost <= myGold)
        {
            int currentTapLevel = CDataManager.instance.GetMyTapUpgradeLevel();
            upgradeCost = currentTapLevel * 3.14f;

            // 레벨 1 증가
            currentTapLevel++;

            CDataManager.instance.SetMyTapUpgradeLevel(currentTapLevel);
            CDataManager.instance.SubMyGold(upgradeCost);

        }

        // UI 갱신
        UIUpgradeCost.text = Mathf.Round(upgradeCost) + "";

    }

    //public void SetUpgradeMultiple(int multiple)
    //{
    //    upgradeMultiple = multiple;
    //    upgradeCost = upgradeCost * (double) upgradeMultiple;

    //    // UI 갱신
    //}

}
