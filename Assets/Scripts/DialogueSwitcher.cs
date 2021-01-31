using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class DialogueSwitcher : MonoBehaviour
{
    public Text dialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("switchcolor")]
    public void ChangeColor(string colorName)
    {
        int color = int.Parse(colorName);
        if (color == 0)
        {
            // Player - white
            dialogue.color = new Color(0.0f, 0.0f, 0.0f);
        }
        else if(color == 1)
        {
            // Shy Kid - blue
            dialogue.color = new Color(0.0f, 121.0f, 255.0f);
        }
        else if(color == 2)
        {
            // Angry Kid - red
            dialogue.color = new Color(255.0f, 0.0f, 0.0f);
        }
        else if(color == 3){
            // Ditzy kid - yellow
            dialogue.color = new Color(255.0f, 0.0f, 0.0f);
        }
        else if(color == 4){
            // Other kid - Purple?
            dialogue.color = new Color(85.0f, 0.0f, 255.0f);
        }
        else
        {
            // Rich Kid - pink
            dialogue.color = new Color(255.0f, 70.0f, 255.0f);
        }
    }
}
