using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public ScriptableInt score;
    public ScriptableUser user;
    public Text myText;

    protected void Start()
    {
        refresh();
    }

    public void add(int amount)
    {
        score.Value += amount;
        refresh();
    }

    void refresh()
    {
        myText.text = user.Value.Name + " Your Score is " + score.Value.ToString();
    }
}
