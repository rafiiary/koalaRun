using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Class in control of major things in game like pause and resume */
public class GameController : MonoBehaviour
{
    public static void pauseGame() {
        Time.timeScale = 0;
    }
    public static void resumeGame()
    {
        Time.timeScale = 1;
    }
}
