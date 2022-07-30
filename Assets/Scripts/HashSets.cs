using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HashSets
{
    static HashSet<string> people = new HashSet<string>() { "Joe", "Joan", "Hank" };
    static HashSet<string> activePlayers = new HashSet<string>() { "Harrison", "Alex", "Haley" };
    static HashSet<string> inactivePlayers = new HashSet<string>() { "Kelsey", "Basel" };
    static HashSet<string> premiumPlayers = new HashSet<string>() { "Haley", "Basel" };


    public static void OperationWithHashSet()
    {
        // Добавление элементов в HashSet
        people.Add("Walter");
        people.Add("Evelyn");
        // Удаление элементов в HashSet
        people.Remove("Joe");
        // Операция объединение
        UnionHashSet();
        // Операция пересечение
        IntersectHashSet();
        // Операция вычитание
        ExceptHashSet();
    }
    static void UnionHashSet()
    {
        // Операция объединение
        activePlayers.UnionWith(inactivePlayers);
    }
    static void IntersectHashSet()
    {
        // Операция пересечение
        activePlayers.IntersectWith(premiumPlayers);
    }
    static void ExceptHashSet()
    {
        // Операция вычитание
        activePlayers.ExceptWith(premiumPlayers);
    }

}
