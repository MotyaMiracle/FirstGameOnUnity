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
        // Очистка стека и сброс счетчика на 0
        lootStack.Clear();
        // Поиск определенного элемента в стеке
        var itemFound = lootStack.Contains("Golden Key");
        // Копирование элементов стека в массив
        string[] copiedLoot = new string[lootStack.Count];
        lootStack.CopyTo(copiedLoot, 0);
        // Преобразование стека в массив и строку
        lootStack.ToArray();
        lootStack.ToString();
        // Проверка есть ли след.элемент в стеке
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
