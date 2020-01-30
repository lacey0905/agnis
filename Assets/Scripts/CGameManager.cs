using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CGameManager : MonoBehaviour
{


    public CMonsterManager monsterManager;
    public CGoldManager goldManager;

    private int stageIncrease = 1;


    public delegate void Handler();
    public static event Handler handler;

    public static CGameManager instance;

    private void Awake()
    {
        CGameManager.instance = this;
    }

    private void test()
    {
        handler();
    }

    void Start()
    {  

        // 게임 시작 하기
        // 몬스터 생성
        monsterManager.Create();


        test();

    }

    void Update()
    {

        // 몬스터가 Die 되면 실행
        if((int)monsterManager.monsterState == 2)
        {
            //Debug.Log("몬스터 Die");

            int currentStage = CDataManager.instance.GetCurrentStage();

            CDataManager.instance.SetCurrentStage(currentStage + stageIncrease);

            // 몬스터 레디 상태로 변경
            monsterManager.Ready();

            // 돈 생성
            goldManager.CreateGold();

            // 몬스터 새로 생성
            monsterManager.Create();

        }

        if (Input.GetMouseButtonDown(0))
        {
            

        }

    }

    public void ScreenTap()
    {
        // 몬스터가 Alive 일때만
        if ((int)monsterManager.monsterState == 1)
        {
            int myTabLevel = CDataManager.instance.GetMyTapUpgradeLevel();

            // 임시 데미지 공식
            float myTabDamage = myTabLevel * 3.14f;
            monsterManager.Attack(myTabDamage);

        }

        // 공격 애니메이션 : 몹이 없어도 공격은 눌리게
    }

}
