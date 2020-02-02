using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldController : MonoBehaviour
{

    public static GoldController instance;

    public Gold goldPrefab;

    private void Awake()
    {
        GoldController.instance = this;
    }


    public void SpawnGold(double gold)
    {
        Gold fieldGold = Instantiate(goldPrefab, transform.position, Quaternion.identity) as Gold;
        fieldGold.Money = gold;
    }


}
