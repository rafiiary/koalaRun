using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PoisonGasDamage : MonoBehaviour
{
    public Collider2D player;
    public Slider breathSlider;

    int playerBreath;
    Coroutine suffer;
    Coroutine breathe;
    private void Start()
    {
        playerBreath = 100;
        breathSlider.value = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Starting suffocation");
            suffer = StartCoroutine(Suffocate());
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        { 
            StopCoroutine(suffer);
            Debug.Log("Starting health regeneration");
            breathe = StartCoroutine(regenerateBreath());
        }   
    }
    private IEnumerator Suffocate()
    {
        while(playerBreath >= 0)
        {
            playerBreath -= 1;
            breathSlider.value += 0.01f;
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }
    private IEnumerator regenerateBreath()
    {
        while(playerBreath < 100)
        {
            playerBreath += 1;
            breathSlider.value -= 0.01f;
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }
    private void Update()
    {
        if(playerBreath < 0)
        {
            playerBreath = 100;
            breathSlider.value = 0;
            PlayerAttributeController.removeHealth();
        }
        else if (playerBreath > 100)
        {
            playerBreath = 100;
            breathSlider.value = 0;
            StopCoroutine(breathe);
        }
    }
}
