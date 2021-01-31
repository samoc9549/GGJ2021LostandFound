using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public string nextScene;
    public string startNode;
    public GameObject fadeOut;
    public GameObject fadeIn;
    public DialogueRunner dialogue;
    public ScoreTracker score;

    private void Awake()
    {
        fadeIn.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        fadeOut.SetActive(false);
        StartCoroutine(Enter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("end")]
    public void EndCall(string result)
    {
        if(result == "pass")
        {
            score.AddScore();
        }
        StartCoroutine(End());
    }

    IEnumerator Enter()
    {
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(0.4f);
        dialogue.StartDialogue(startNode);
    }

    IEnumerator End()
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(nextScene);
    }
}
