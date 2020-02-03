using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{

    public double Money { get; set; }

    private void Update()
    {
        
        // 일정 시간 지나면 자동 획득

    }

    public void DoWallet()
    {
        DataController.instance.PlayerGold = this.Money;

    }

}
