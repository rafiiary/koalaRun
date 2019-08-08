using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCanvasController : MonoBehaviour
{
    public Transform player;
    public GameObject MovementPanel;
    public GameObject jumpPanel;
    private void Start()
    {
        //Movement panel should be visible from the start
        MovementPanel.SetActive(true);
        GameController.pauseGame();
    }
    void Update()
    {
        //Disable movement panel after player starts moving
        if(MovementPanel.active == true && (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A)))
        {
            MovementPanel.SetActive(false);
            GameController.resumeGame();
        }
        if(jumpPanel != null && player.position.x > 0)
        {
            Debug.Log("Player at position x=0");
            GameController.pauseGame();
            jumpPanel.SetActive(true);
        }
        if(jumpPanel != null && Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(jumpPanel);
            GameController.resumeGame();
        }
        
    }
}
