using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributeController : MonoBehaviour
{
    public static int health;
    public static int leaves;
    public static int breath;
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
        health--;
    }

    /* Add a health in case player somehow received an extra health */
    public static void addHealth()
    {
        health++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("poison"))
        {
            StartCoroutine(startPoisoning());
        }
    }

    //Person's breath starts going away
    IEnumerator startPoisoning()
    {
        if(breath > 0)
        {
            breath -= 1;
            yield return new WaitForSecondsRealtime(0.01f);
        }
    }
    private void Update()
    {
        if(breath <= 0)
        {
            removeHealth();   
        }
    }
}
