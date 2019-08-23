using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerLifeController : MonoBehaviour
{
    public  GameObject [] hearts;
    public  Sprite fullHeart;
    public  Sprite emptyHeart;

    public void updateHealthVisual()
    {
        int i = 0;
        while (i < PlayerAttributeController.health)
        {
            //hearts[i]
            i++;
        }
        while (i < hearts.Length)
        {
            //hearts[i].getComponent<RawImage>().sprite = emptyHeart;
            i++;
        }
    }
}
