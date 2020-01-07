using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTabUpgrade : MonoBehaviour
{

    private double upgradeCost;
    private int upgradeMultiple;
    
    // 다음 레벨 UI 표시

    public void Upgrade()
    {
        upgradeCost = upgradeCost * upgradeMultiple;

        double myGold = CDataManager.instance.GetMyGold();

        if (upgradeCost <= myGold)
        {
            int currentTapLevel = CDataManager.instance.GetMyTapUpgradeLevel();
            CDataManager.instance.SetMyTapUpgradeLevel(currentTapLevel * upgradeMultiple);
            CDataManager.instance.SubMyGold(upgradeCost);
        }

        // UI 갱신

    }

    public void SetUpgradeMultiple(int multiple)
    {
        upgradeMultiple = multiple;
        upgradeCost = upgradeCost * upgradeMultiple;

        // UI 갱신
    }

}
