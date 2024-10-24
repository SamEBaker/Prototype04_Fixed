using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public int TotalGold = 0;
    public int totalPlayers = 0;
    public int totalReady = 0;
    public UnityEvent startGame;
    public GameObject StartGameMenu;
    public List<GameObject> PlayerUISetUp;
    //public GameObject threeplayerFillerUI;

    public void TotalAddGold(int gold)
    {
        TotalGold += gold;
    }
    public void SetupUI(int index)
    {
        PlayerUISetUp[index - 1].SetActive(true);
    }
    public void AddPlayer()
    {
        totalPlayers++;
        SetupUI(totalPlayers);
    }
    public void ReadyUp()
    {
        totalReady ++;
    }

    public void StartGame()
    {
        if(totalPlayers == totalReady)
        {
            //start game and timer
            StartGameMenu.SetActive(false);
            //threeplayerFillerUI.SetActive(true);
            startGame.Invoke();
        }

    }
}
