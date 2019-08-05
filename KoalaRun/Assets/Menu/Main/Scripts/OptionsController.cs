using TMPro;
using UnityEngine;

public class OptionsController : MonoBehaviour
{
    /* The number of options available in menu */
    public int numberOfOptions;

    /* The option player is currently hovering over. The
     * integer represents the index in options list */
    public static int currOption;

    /* List to hold all the options, the gameobjects are 
     * TextMeshPro objects */
    public GameObject[] options;
  
    void Start()
    {
        currOption = 0;
        updateOptionChosen();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            returnToOriginal(currOption);
            if(currOption == numberOfOptions - 1)
            {
                currOption = 0;
            }
            else
            {
                currOption++;
            }
            updateOptionChosen();
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            returnToOriginal(currOption);
            if (currOption == 0)
            {
                currOption = numberOfOptions - 1;
            }
            else
            {
                currOption--;
            }
            updateOptionChosen();
        }

    }
    /* Highlights the current option the player is hovering over */
    void updateOptionChosen()
    {
        //Get the text of the current option
        TextMeshProUGUI currText;
        currText = options[currOption].GetComponent<TextMeshProUGUI>();

        //Highlight the option
        currText.text = "\t" + currText.text;
        currText.color = new Color(0, 0, 0);
    }

    /* Return the original option back to normal 
     * before changing the next option */
    void returnToOriginal(int originalIndex)
    {
        //Get the original text
        TextMeshProUGUI originalText;
        originalText = options[originalIndex].GetComponent<TextMeshProUGUI>();

        //Unhighlight the option
        originalText.text = originalText.text.Substring(1); 
        originalText.color = new Color(1, 1, 1);
    }
}
