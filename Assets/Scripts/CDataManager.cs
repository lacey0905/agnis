using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CDataManager : MonoBehaviour
{
    private double myGold;
    private int myRuby;
    
    private int currentStage;
    private int startStage = 1;
    
    private int currentMonsterStep;
    private int maxMonsterStep;

    private int myTapUpgradeLevel;
    private int startMyTapLevel = 1;

    public static CDataManager instance;

    public Text UITextMyGold;
    public Text UITextCurrentStage;

    private void Awake()
    {
        CDataManager.instance = this;

        // 시작 할 때 셋팅
        currentStage = startStage;
        myTapUpgradeLevel = startMyTapLevel;

        UITextCurrentStage.text = GetCurrentStage() + "";

    }


    // 골드
    public double GetMyGold()
    {
        return myGold;
    }
    public void AddMyGold(double gold)
    {
        myGold += gold;

        // 골드 UI 갱신
        UITextMyGold.text = GetMyGold() + "";
    }
    public void SubMyGold(double gold)
    {
        myGold -= gold;

        // 골드 UI 갱신
        UITextMyGold.text = GetMyGold() + "";
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

        UITextCurrentStage.text = GetCurrentStage() + "";
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
    */

}
