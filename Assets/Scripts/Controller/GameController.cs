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
        
        if(Input.GetMouseButtonDown(0))
        {





        }



    }



}
