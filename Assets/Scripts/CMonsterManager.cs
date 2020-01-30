
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CMonsterManager : MonoBehaviour
{

    public static CMonsterManager instance;


    private void Awake()
    {
        CMonsterManager.instance = this;
    }


    private void OnEnable()
    {
        CGameManager.handler += this.MonsterTest;
    }

    public void MonsterTest()
    {
        Debug.Log("몬스터에서 실행 TEST");
    }


     
    private float maxMonsterHealth;
    private float currentMonsterHealth;

    public Text UITextMonsterHealth;
    public Slider UISliderMonsterHealth;

    public enum MonsterStage
    {
        Ready = default,
        Alive,
        Die
    }

    public MonsterStage monsterState;

    public void Create()
    {
        //Debug.Log("몬스터 새로 생성");

        monsterState = MonsterStage.Alive;

        // 스테이지 가져오기
        int currentStage = CDataManager.instance.GetCurrentStage();

        // 몬스터 체력 수식 예정
        maxMonsterHealth = currentStage * 10f;
        currentMonsterHealth = maxMonsterHealth;

        // 몹 생성 및 UI 갱신
        DrawUI();
    }

    public void Attack(float damage)
    {
        currentMonsterHealth -= damage;

        // 몬스터 다이
        if (currentMonsterHealth <= 0)
        {
            // 체력이 -가 되지 않게
            currentMonsterHealth = 0;

            // 몬스터 Die
            Die();
        }
        else
        {
            // 몬스터 맞는 효과나 이런거
        }

        DrawUI();

    }

    public void DrawUI()
    {
        // HP UI 그리기
        UITextMonsterHealth.text = Mathf.Round((float)currentMonsterHealth) + " HP";
        UISliderMonsterHealth.maxValue = maxMonsterHealth;
        UISliderMonsterHealth.value = currentMonsterHealth;
    }


    public void Die()
    {
        // 몬스터 다이 효과

        // 몬스터 Die 상태로 바꾸기
        monsterState = MonsterStage.Die;
    }

    public void Ready()
    {
        monsterState = MonsterStage.Ready;
    }


}
