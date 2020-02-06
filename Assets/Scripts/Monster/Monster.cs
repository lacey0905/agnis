using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{

    public Monster(double maxHP, string monsterName)
    {
        this.MaxHP = maxHP;
        this.CurrentHP = maxHP;
        this.MonsterName = monsterName;
    }

    public double MaxHP { get; set; }
    public double CurrentHP { get; set; }
    public string MonsterName { get; set; }

    public bool IsDead
    {
        get
        {
            return this.CurrentHP <= 0d;
        }
    }

    public void Damage(double damage)
    {
        CurrentHP -= damage;
        if (CurrentHP <= 0d) CurrentHP = 0d;
    }

}
