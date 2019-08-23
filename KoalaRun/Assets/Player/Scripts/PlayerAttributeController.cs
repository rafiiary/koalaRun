using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributeController : MonoBehaviour
{
    public static int health;
    public static int leaves;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        leaves = 0;
    }

    /* Add a leaf to the number of leaves player currently holds */
    public static void addLeaf()
    {
        leaves++;
    }

    public static int Leaves
    {
        /* Return the number of leaves */
        get
        {
            return leaves;
        }
    }
    
    /* Remove a health in case player died */
    public static void removeHealth()
    {
        Debug.Log("Removed health");
        health--;
    }

    /* Add a health in case player somehow received an extra health */
    public static void addHealth()
    {
        health++;
    }
}
