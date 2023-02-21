using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdaterUsingScripEvent : MonoBehaviour
{
    Text myText;
    int score = 0;

    protected void Start()
    {
        myText = this.GetComponent<Text>();
        refresh();
    }

    public void add(int amount)
    {
        score += amount;
        refresh();
    }

    void refresh()
    {
        myText.text = " Your Score is " + score.ToString();
    }
}


