using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController instance;

    private void Awake()
    {
        GameController.instance = this;
    }


    private void Update()
    {


        // 입력 받음
        if(Input.GetMouseButtonDown(0))
        {


        }

    }

    private void Start()
    {
        // 게임 시작
        int stage = DataController.instance.CurrentStage;
        StageController.instance.MonsterSpawn(stage);
    }

    public void Attack()
    {
        PlayerController.instance.DoAttack(Vector3.zero);
    }

    public void PlayerLevelUp()
    {
        PlayerController.instance.PlayerLevelUp(1);
    }


}
