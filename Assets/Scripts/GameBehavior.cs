using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CustomExtensions;

public class GameBehavior : MonoBehaviour, IManager
{
    public string labelText = "Collect all 4 items and win your freedom!";
    public int maxItems = 4;

    public bool showWinScreen = false;
    public bool showLossScreen = false;
    private string _state;
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }
    private int _itemsCollected = 0;
    public int Items
    {
        get { return _itemsCollected; }
        set { _itemsCollected = value;
            ShowWinScreen(_itemsCollected);
        }
    }
    private int _playerHP = 1;
    public int HP
    {
        get { return _playerHP; }
        set { _playerHP = value;
            ShowLossScreen(_playerHP);
            Debug.Log($"Lives: {_playerHP}"); 
        }
    }
    public delegate void DebugDelegate(string newText);
    public DebugDelegate debug = Print;
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
        //InventoryList<string> inventoryList = new InventoryList<string>();
        //inventoryList.SetItem("Potion");
        //Debug.Log(inventoryList.item);

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Initialize()
    {
        _state = "Manager initialized...";
        //_state.FancyDebug();
        //Debug.Log(_state);
        //Stacks.OpertionWithStack();
        //Queues.OperationWithQueue();
        debug(_state);
        LogWithDelegate(debug);
        GameObject player = GameObject.Find("Player");
        PlayerBehavior playerBehavior = player.GetComponent<PlayerBehavior>();
        playerBehavior.playerJump += HandlePlayerJump;
    }
    public void HandlePlayerJump()
    {
        Debug.Log("Player has jumped...");
    }
    public static void Print(string newText)
    {
        Debug.Log(newText);
    }
    public void LogWithDelegate(DebugDelegate del)
    {
        del("Delegating the debug task...");
    }
    void ShowLossScreen(int playerHP)
    {
        if (playerHP <= 0)
        {
            labelText = "You want another life with that?";
            showLossScreen = true;
            Time.timeScale = 0;
        }
        else
        {
            labelText = "Ouch... that's got hurt.";
        }
    }
    void ShowWinScreen(int itemCollected)
    {
        if (itemCollected >= maxItems)
        {
            labelText = "You've found all the items!";
            showWinScreen = true;
            Time.timeScale = 0;
        }
        else
            labelText = "Items found, only " + (maxItems - itemCollected) + " more to go!";
    }
    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player Health: " + _playerHP);

        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " + _itemsCollected);

        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

        if (showWinScreen)
        {
            if(GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "YOU WON!"))
            {
                Utilities.RestartLevel(0);
            }
        }
        if (showLossScreen)
        {
           if(GUI.Button(new Rect(Screen.width/2-100, Screen.height/2-50,200,100), "You lose..."))
            {
                try
                {
                    Utilities.RestartLevel(-1);
                    debug("Level restarted successfully...");
                }
                catch (System.ArgumentException e)
                {
                    Utilities.RestartLevel(0);
                    debug("Reverting to scene 0: " + e.ToString());
                }
                finally
                {
                    debug("Restart handled...");
                }
                
            }
        }
    }
    public void PrintLootReport()
    {
        Stacks.PrintLootReport();
    }

}
