using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Queues
{
    // �������� ������� �� ��������� ���������
    static Queue<string> activePlayers = new Queue<string>();
    public static void OperationWithQueue()
    {
        // ���������� ��������� � �������
        activePlayers.Enqueue("Harrison");
        activePlayers.Enqueue("Alex");
        activePlayers.Enqueue("Haley");
        // �������� ������� �������� � �������, �� ������ ���
        activePlayers.Peek();
        // ���������� � ������� ������ ������� � �������
        activePlayers.Dequeue();
    }
}
