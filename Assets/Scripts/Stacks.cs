using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Stacks
{  
    public static Stack<string> lootStack = new Stack<string>();

    public static void OpertionWithStack()
    {
        lootStack.Push("Sword of Doom");
        lootStack.Push("HP+");
        lootStack.Push("Golden Key");
        lootStack.Push("Winged Boot");
        lootStack.Push("Mythril Bracers");
        // ������� ����� � ����� �������� �� 0
        lootStack.Clear();
        // ����� ������������� �������� � �����
        var itemFound = lootStack.Contains("Golden Key");
        // ����������� ��������� ����� � ������
        string[] copiedLoot = new string[lootStack.Count];
        lootStack.CopyTo(copiedLoot, 0);
        // �������������� ����� � ������ � ������
        lootStack.ToArray();
        lootStack.ToString();
        // �������� ���� �� ����.������� � �����
        string lootItem = "";
        bool itemPresent = lootStack.TryPeek(out lootItem);
        if (itemPresent)
            Debug.Log(lootItem);
        else
            Debug.Log("Stack it empty");

        itemPresent = lootStack.TryPop(out lootItem);
        if (itemPresent)
            Debug.Log(lootItem);
        else
            Debug.Log("Stack it empty");
    }
    public static void PrintLootReport()
    {
        var currentItem = lootStack.Pop();
        var nextItem = lootStack.Peek();
        Debug.Log($"You got a {currentItem}! You've got a good chance of finding a {nextItem} next!");
        Debug.Log($"There are {lootStack.Count} random loot items waiting for you!");
    }
}
