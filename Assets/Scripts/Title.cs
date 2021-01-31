using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public ScoreTracker score;
    public string nextScene;
    public GameObject fadeOut;
    // Start is called before the first frame update
    void Start()
    {
        fadeOut.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeginGame()
    {
        StartCoroutine(NextScene());

    }

    IEnumerator NextScene()
    {
        score.SetScore(0);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(nextScene);
    }
}
