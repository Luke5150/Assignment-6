/*
 * (Luke Hensley)
 * (Assignment 6)
 * (Controls coin function)
 */
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class CoinBehavior : MonoBehaviour, Collectibles
{

    public virtual int addScore(int value, int currentTotal)
    {
        currentTotal += value;

        return currentTotal;
        
    }


}
