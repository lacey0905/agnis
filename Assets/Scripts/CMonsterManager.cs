
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMonsterManager : MonoBehaviour
{
    private double maxMonsterHealth;
    private double currentMonsterHealth;

    public void Create()
    {
        // 스테이지 가져오기
        int currentStage = CDataManager.instance.GetCurrentStage();

        // 몬스터 체력 수식 예정
        maxMonsterHealth = currentStage * 10d;
        currentMonsterHealth = maxMonsterHealth;

        // 몹 생성 및 UI 갱신
    }

    public void Attack(double damage)
    {
        currentMonsterHealth -= damage;

        // 몬스터 다이
        if(currentMonsterHealth <= 0)
        {
            // 체력이 -가 되지 않게
            currentMonsterHealth = 0;

            // 몬스터 Die 기능 실행

        }
        else
        {
            // 몬스터 맞는 효과나 이런거
        }
    }

    public void Die()
    {
        // 몬스터 다이 효과

        // 몬스터 새로 생성

        // 돈 생성
    }

}
