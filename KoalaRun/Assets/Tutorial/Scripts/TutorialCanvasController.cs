using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialCanvasController : MonoBehaviour
{
    public Transform player;
    public GameObject MovementPanel;
    public GameObject jumpPanel;
    public GameObject leafPanel;
    public GameObject poisonGasPanel;

    bool leafPanelShown;
    bool poisonGasPanelShown;
    private void Start()
    {
        //Movement panel should be visible from the start
        MovementPanel.SetActive(true);
        GameController.pauseGame();
        leafPanelShown = false;
        poisonGasPanelShown = false;
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
            GameController.pauseGame();
            jumpPanel.SetActive(true);
        }
        if(jumpPanel != null && Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(jumpPanel);
            GameController.resumeGame();
        }
        if(leafPanel != null && player.position.x > 6)
        {
            GameController.pauseGame();
            leafPanelShown = true;
            leafPanel.SetActive(true);
        }
        if(leafPanel != null && leafPanelShown && Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(leafPanel);
            GameController.resumeGame();
        }
        if(poisonGasPanel != null && player.position.x > 34)
        {
            GameController.pauseGame();
            poisonGasPanelShown = true;
            poisonGasPanel.SetActive(true);
        }
        if(poisonGasPanel != null && poisonGasPanelShown && Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(poisonGasPanel);
            GameController.resumeGame();
        }
        
    }
}
