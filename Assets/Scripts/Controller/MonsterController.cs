using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{

    public static MonsterController instance;

    private void Awake()
    {
        MonsterController.instance = this;
    }


    public void SpawnFieldMonster()
    {

    }



}
