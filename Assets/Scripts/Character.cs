using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Создаем пользовательский класс.
public class Character
{
    // Целочисленные переменные.
    public int exp = 0;
    //Строковые переменные.
    public string name;
    
    

    public Character()
    {
        name = "Not assigned";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public Character(string name, int exp) : this(name)
    {
        this.exp = exp;
    }

    // Полиморфизм.
    public virtual void PrintStatsInfo()
    {
        Debug.Log($"Hero: {name} - {exp} EXP");
    }

    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    
    public void PrintWeaponStats()
    {
        Debug.Log($"Weapon: {name} - {damage} DMB");
    }
}

public class Paladin : Character
{
    public Weapon weapon;

    public Paladin(string name,Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    // Полиморфизм.
    public override void PrintStatsInfo()
    {
        Debug.Log($"Hail {name} - take up your {weapon.name}!");
    }
}
