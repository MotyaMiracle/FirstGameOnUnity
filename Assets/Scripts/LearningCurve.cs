using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Целочисленные переменные.
    private int currentAge = 30;
    public int addedAge = 1;
    public int currentGold = 55;
    public int diceRoll = 7;
    public int goldOfHero = 300;
    public int playerLives = 3;

    // Вещественные переменные.
    public float pi = 3.14f;

    // Строковые переменные.
    public string firstName = "Harrison";
    public string rareItem = "Behelit";
    public string characterAction = "Attack";

    // Логические переменные.
    public bool isAuthor = true;
    public bool pureOfHeart = true;
    public bool hasSecretIncatation = false;

    // Пользовательские типы.
    private Transform camTransform;
    public GameObject directionLight;
    private Transform lightTransform;

    // Start is called before the first frame update
    void Start()
    {
        //ComputeAge();

        //Debug.Log($"a string can have variables like {firstName} inserted directly");

        // Тестирование методов.
        //int characterLevel = 80;
        //int nextSkillLevel = GenerateCharacter("Casca", characterLevel);
        //Debug.Log(nextSkillLevel);
        //Debug.Log(GenerateCharacter("Griffith", characterLevel));
        //GenerateCharacter("Guts", 100);

        // Вызов метода для испытания героя.
        //Trial(666);
        //Trial(GenerateCharacter("Guts", 100));

        // Тестирование условных операторов.
        //PocketChange();
        //OpenTreasureChamber();
        //SwitchingAround();

        // Создание и работа со списками.
        //List<string> questPartyMembers = new List<string>() { "Guts", "Casca", "Griffith" };
        //questPartyMembers.Add("Judeau");
        //questPartyMembers.Insert(3, "Rickert");
        ////questPartyMembers.RemoveAt(4);
        //questPartyMembers.Remove("Judeau");
        //Debug.Log($"Party Members: {questPartyMembers.Count}");

        // Создание и работа со словарями.
        //Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        //{
        //    {"Sword", 1},
        //    {"Healing Salve", 5},
        //    {"Clarity", 3}
        //};
        //Debug.Log($"Items: {itemInventory.Count}");
        //int numberOfHealingSalve = itemInventory["Healing Salve"];
        //itemInventory["Healing Salve"] = 7;
        //itemInventory.Add("Shield", 1);
        //itemInventory["Bandage"] = 6;
        //if (itemInventory.ContainsKey("Clarity"))
        //{
        //    itemInventory["Clarity"] = 4;
        //}
        //itemInventory.Remove("Healing Salve");
        //Debug.Log($"Items: {itemInventory.Count}");

        // Создание и работа с циклами.
        //for (int i = 0; i < itemInventory.Count; i++)
        //{
        //    Debug.Log($"Index: {i} - {questPartyMembers[i]}");

        //    if (questPartyMembers[i] == "Casca")
        //        Debug.Log("Glad you're here Casca!");
        //}

        //foreach (string partyMember in questPartyMembers)
        //{
        //    Debug.Log($"{partyMember} - Here!");
        //}

        //foreach(KeyValuePair<string, int> kvp in itemInventory)
        //{
        //    Debug.Log($"Item: {kvp.Key} - {kvp.Value}g");
        //}

        // Испытание героя. Ищем подходящие предметы.
        //Dictionary<string, int> priceInShop = new Dictionary<string, int>()
        //{
        //    {"Sword", 150},
        //    {"Healing Salve", 50},
        //    {"Clarity", 30},
        //    {"Shadowmourne", 500}
        //};
        //foreach(KeyValuePair<string, int> kvp in priceInShop)
        //{
        //    if(goldOfHero > kvp.Value)
        //        Debug.Log($"Your budget allows you to buy {kvp.Key}");
        //    else
        //        Debug.Log($"Your budget does not allow you to buy {kvp.Key}");
        //}

        //while (playerLives > 0)
        //{
        //    Debug.Log($"Player still alive, he has lives - {playerLives}");
        //    playerLives--;
        //}
        //Debug.Log("Player KO'd");

        // Создание экземпляра класса.
        Character hero = new Character();
        //Debug.Log($"Hero: {hero.name} - {hero.exp} EXP");
        //hero.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        //Debug.Log($"Hero: {heroine.name} - {heroine.exp} EXP");
        //heroine.PrintStatsInfo();

        // Использование структуры.
        //Weapon huntingBow = new Weapon("Hunting Bow", 105);
        //huntingBow.PrintWeaponStats();

        // Ссылочные типы.
        //Character hero2 = hero;
        //hero.PrintStatsInfo();
        //hero2.PrintStatsInfo();
        //hero2.name = "Guts";
        //hero2.PrintStatsInfo();

        // Типы значения.
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        //Weapon warBow = huntingBow;
        //huntingBow.PrintWeaponStats();
        //warBow.PrintWeaponStats();
        //warBow.name = "War Bow";
        //warBow.damage = 155;
        //warBow.PrintWeaponStats();

        // Инкапсуляция.
        //Character hero2 = hero;
        //hero.PrintStatsInfo();
        //hero2.PrintStatsInfo();
        //hero2.Reset();

        // Наследование.
        //Paladin knight = new Paladin("Sir Arthur", huntingBow);
        //knight.PrintStatsInfo();

        // Получение доступа к компонентам на одном объекте.
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        // Поиск компонентов на разных объектах.
        //directionLight = GameObject.Find("Directional Light");

        lightTransform = directionLight.GetComponent<Transform>();
        Debug.Log(lightTransform.localPosition);
    }

    /// <summary>
    /// Испытание героя. Рассматриваем методы как аргументы.
    /// </summary>
    /// <param name="number"></param>
    public void Trial(int number)
    {
        Debug.Log(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    ///  Computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }

    /// <summary>
    /// Генерирует и возвращает персонажа с именем и уровнем.
    /// </summary>
    /// <param name="nameCharacter"></param>
    /// <param name="lvlCharacter"></param>
    /// <returns></returns>
    public int GenerateCharacter(string nameCharacter, int lvlCharacter)
    {
        Debug.Log($"Name: {nameCharacter} - Level: {lvlCharacter}");
        //Debug.LogFormat("Name: {0} - Level: {1}", nameCharacter, lvlCharacter);
        return lvlCharacter + 5;
    }

    /// <summary>
    /// Использование if-else конструкций.
    /// </summary>
    public void PocketChange()
    {
        if (currentGold > 50)
            Debug.Log($"Число - {currentGold} превышает 50");
        else if (currentGold < 15)
            Debug.Log($"Число - {currentGold} меньше 15");
        else
            Debug.Log($"Число - {currentGold}, сработало else");
    }

    /// <summary>
    /// Использование if-else конструкций и вложенных условий.
    /// </summary>
    public void OpenTreasureChamber()
    {
        if (pureOfHeart && rareItem == "Behelit")
            if (!hasSecretIncatation)
                Debug.Log($"I have a {rareItem}, but don't have secret incatation");
            else
                Debug.Log($"I have a {rareItem} and secret incatation!");
        else
            Debug.Log($"I have dark of heart and don't have a {rareItem}");
    }

    /// <summary>
    /// Использование Switch конструкций.
    /// </summary>
    public void SwitchingAround()
    {
        switch (characterAction)
        {
            case "Heal":
                Debug.Log("Healing");
                break;
            case "Attack":
                Debug.Log("Attacking");
                break;
            default:
                Debug.Log("Defending");
                break;
        }
        // Использование "провалов".
        switch (diceRoll)
        {
            case 7:
            case 15:
                Debug.Log($"Number is 15");
                break;
            case 20:
                Debug.Log($"Number is 20");
                break;
            default:
                Debug.Log($"Number is {diceRoll}");
                break;
        }
    }
}
