using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageController : MonoBehaviour
{

    public static StageController instance;


    public Text HP;


    private void Awake()
    {
        StageController.instance = this;
    }

    private Monster fieldMonster;

    public void MonsterSpawn(int stage)
    {
        if(WaveComplete)
        {
            // 보스
            string newName = "테스트";
            double newHp = this.GetStageBaseHP(stage);
            fieldMonster = new Monster(newHp, newName);

            HP.text = fieldMonster.CurrentHP.ToString();
        }
        else
        {
            string newName = "테스트";
            double newHp = this.GetStageBaseHP(stage);
            fieldMonster = new Monster(newHp, newName);

            HP.text = fieldMonster.CurrentHP.ToString();
        }
    }

    public void MonsterDamage(double damage)
    {
        
        fieldMonster.Damage(damage);

        HP.text = fieldMonster.CurrentHP.ToString();

        if (fieldMonster.IsDead)
        {
            fieldMonster = null;
            MonsterDeath();
        }
    }

    public void MonsterDeath()
    {
        int stage = DataController.instance.CurrentStage;

        if (WaveComplete)
        {
            MoveToNextStage(stage);
        }
        else
        {
            
            int newWave = DataController.instance.CurrentWave + 1;

            GoldController.instance.SpawnGold(GetStageBaseGold(stage));
            DataController.instance.CurrentWave = newWave;

            MonsterSpawn(stage);

            //MonsterController.instance.SpawnFieldMonster();

        }
    }

    public void MoveToNextStage(int stage)
    {
        if (stage % 5 == 0)
        {
            //5의 배수 탄 일때

        }
        else
        {
            DataController.instance.CurrentWave = 1;
            DataController.instance.CurrentStage = stage + 1;
            MonsterSpawn(DataController.instance.CurrentStage);
        }
    }

    public bool WaveComplete
    {
        get
        {
            return DataController.instance.CurrentWave >= 10;
        }
    }


    public double GetStageBaseHP(int stage)
    {
        double hp = (double)18.5f * System.Math.Pow((double)1.57f, (double)System.Math.Min((float) stage, 156f)) * System.Math.Pow
            ((double)1.17f, (double)System.Math.Max((float)stage - 156f, 0f));
        return hp;
    }

    public double GetStageBaseGold(int stage)
    {
        int currentStage = DataController.instance.CurrentStage;
        double stageBaseHP = this.GetStageBaseHP(stage);
        double num = stageBaseHP * (double)(0.02f + 0.00045f * System.Math.Min((float)currentStage, 150f));

        if (num <= 5.0)
        {
            num = (int)System.Math.Round(num);
        }

        return num * System.Math.Ceiling(1.0 + 0f);
    }

}
