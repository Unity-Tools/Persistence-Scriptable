using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SoEventDemoExample
{
    public class UpdateScore : MonoBehaviour
    {
        public ScriptableInt score;
        Text myText;
        int scoreText = 0;
        
        protected void Start()
        {
            myText = this.GetComponent<Text>();
            refresh();
        }

        public void add(ScriptableInt score)
        {
            scoreText += score.value;
            refresh();
        }
        public void sub(ScriptableInt score)
        {
            scoreText -= score.value;
            refresh();
        }
        void refresh()
        {
            myText.text = " Your Score is " + scoreText.ToString();
        }
    }
}


