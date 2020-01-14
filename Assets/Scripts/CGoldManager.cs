using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGoldManager : MonoBehaviour
{

    public CGold gold;

    public void CreateGold()
    {
        Instantiate(gold, transform.position, Quaternion.identity);
    }
    
}
