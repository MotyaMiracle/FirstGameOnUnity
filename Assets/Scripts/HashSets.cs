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
        // ���������� ��������� � HashSet
        people.Add("Walter");
        people.Add("Evelyn");
        // �������� ��������� � HashSet
        people.Remove("Joe");
        // �������� �����������
        UnionHashSet();
        // �������� �����������
        IntersectHashSet();
        // �������� ���������
        ExceptHashSet();
    }
    static void UnionHashSet()
    {
        // �������� �����������
        activePlayers.UnionWith(inactivePlayers);
    }
    static void IntersectHashSet()
    {
        // �������� �����������
        activePlayers.IntersectWith(premiumPlayers);
    }
    static void ExceptHashSet()
    {
        // �������� ���������
        activePlayers.ExceptWith(premiumPlayers);
    }

}
