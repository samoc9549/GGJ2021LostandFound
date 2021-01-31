using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScoreTracker")]
public class ScoreTracker : ScriptableObject
{
    [SerializeField]
    private int score;

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int newScore)
    {
        score = newScore;
    }

    public void AddScore()
    {
        score = score + 1;
    }
}
