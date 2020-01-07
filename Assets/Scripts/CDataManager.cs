using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDataManager : MonoBehaviour
{
    private double myGold;
    private int myRuby;
    private int currentStage;
    private int currentMonsterStep;
    private int maxMonsterStep;
    private int myTapUpgradeLevel;

    public static CDataManager instance;

    private void Awake()
    {
        CDataManager.instance = this;
    }

    // 골드
    public double GetMyGold()
    {
        return myGold;
    }
    public void AddMyGold(double gold)
    {
        myGold += gold;
    }
    public void SubMyGold(double gold)
    {
        myGold -= gold;
    }

    // 루비
    public int GetMyRuby()
    {
        return myRuby;
    }
    public void AddMyRuby(int ruby)
    {
        myRuby += ruby;
    }

    // 스테이지
    public int GetCurrentStage()
    {
        return currentStage;
    }
    public void SetCurrentStage(int stage)
    {
        currentStage = stage;
    }

    // 업그레이드
    public int GetMyTapUpgradeLevel()
    {
        return myTapUpgradeLevel;
    }
    public void SetMyTapUpgradeLevel(int level)
    {
        myTapUpgradeLevel = level;
    }

    /*
        골드
        루비
        스테이지
        몬스터 스탭    

        탭 업글
        #장비 번호 + 업
    */

}
