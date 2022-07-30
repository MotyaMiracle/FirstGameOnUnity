using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Queues
{
    // Создание очереди из строковых элементов
    static Queue<string> activePlayers = new Queue<string>();
    public static void OperationWithQueue()
    {
        // Добавление элементов в очередь
        activePlayers.Enqueue("Harrison");
        activePlayers.Enqueue("Alex");
        activePlayers.Enqueue("Haley");
        // Просмотр первого элемента в очереди, не удаляя его
        activePlayers.Peek();
        // Возвращает и удаляет первый элемент в очереди
        activePlayers.Dequeue();
    }
}
