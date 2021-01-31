using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ender : MonoBehaviour
{
    public ScoreTracker myScore;
    int score;
    public Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        score = myScore.GetScore();
        textScore.text = "Total Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
