using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{

    public static StageController instance; 

    private void Awake()
    {
        StageController.instance = this;
    }

    private Monster fieldMonster;

    public void MonsterSpawn(int stage)
    {
        string newName = "테스트";
        double newHp = this.GetStageBaseHP(stage);
        fieldMonster = new Monster(newHp, newName);
    }

    public void MonsterDamage(double damage)
    {
        fieldMonster.Damage(damage);

        if (fieldMonster.IsDead)
        {
            fieldMonster = null;
            MonsterDeath();
        }
    }

    public void MonsterDeath()
    {

        if (WaveComplete)
        {
            MoveToNextStage();
        }
        else
        {
            int stage = DataController.instance.CurrentStage;
            int newWave = DataController.instance.CurrentWave + 1;


            GoldController.instance.SpawnGold(GetStageBaseGold(stage));


            DataController.instance.CurrentWave = newWave;

            MonsterSpawn(stage);
        }
    }

    public void MoveToNextStage()
    {
        DataController.instance.CurrentWave = 1;
        DataController.instance.CurrentStage = DataController.instance.CurrentStage + 1;
        MonsterSpawn(DataController.instance.CurrentStage);
    }

    public bool WaveComplete
    {
        get
        {
            return true;
            //return this.killsInWave >= this.GetNumOfEnemiesInWave();
        }
    }


    public double GetStageBaseHP(int stage)
    {
        return 0;
        //return (double)ServerVarsModel.monsterHPMultiplier * Math.Pow((double)ServerVarsModel.monsterHPBase1, (double)Math.Min((float)stage, ServerVarsModel.monsterHPLevelOff)) * Math.Pow((double)ServerVarsModel.monsterHPBase2, (double)Math.Max((float)stage - ServerVarsModel.monsterHPLevelOff, 0f));
    }

    public double GetStageBaseGold(int stage)
    {
        return 0;
        //double stageBaseHP = this.GetStageBaseHP(stage);
        //double num = stageBaseHP * (double)(ServerVarsModel.monsterGoldMultiplier + ServerVarsModel.monsterGoldSlope * Math.Min((float)this.currentStage, ServerVarsModel.noMoreMonsterGoldSlope));
        //return num * Math.Ceiling(1.0 + PlayerModel.instance.GetStatBonus(BonusType.GoldAll));
    }

}
