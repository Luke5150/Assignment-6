/*
 * (Luke Hensley)
 * (Assignment 6)
 * (Controls end goal function)
 */
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class WinCoinBehavior : CoinBehavior
{
    public GameObject manager;

    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("GameManager");
    }

    public override int addScore(int value, int currentTotal)
    {
        currentTotal += value;

        Victory();
        
        return currentTotal;

    }

    public void Victory()
    {
        manager.GetComponent<GameManager>().UnloadCurrentLevel();
    }
}
    