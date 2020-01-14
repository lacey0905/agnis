using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGameManager : MonoBehaviour
{

    public CMonsterManager monsterManager;


    void Start()
    {


        // 게임 시작 하기
        // 몬스터 생성
        monsterManager.Create();


    }

    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {

            int myTabLevel = CDataManager.instance.GetMyTapUpgradeLevel();

            // 임시 데미지 공식
            double myTabDamage = myTabLevel * 3.14;

            monsterManager.Attack(myTabDamage);

        }

    }


    

}
