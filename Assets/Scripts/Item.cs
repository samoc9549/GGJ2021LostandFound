using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Item : MonoBehaviour
{
    public DialogueRunner dialogue;
    public string nodeName;
    public GameObject buttonOne;
    public GameObject buttonTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickItem()
    {
        dialogue.Stop();
        buttonOne.SetActive(false);
        buttonTwo.SetActive(false);
        dialogue.StartDialogue(nodeName);
        gameObject.SetActive(false);
    }
}
