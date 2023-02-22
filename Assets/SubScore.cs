using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SoEventDemoExample
{
    public class SubScore : MonoBehaviour
    {
        Text myText;
        int score = 0;

        protected void Start()
        {
            myText = this.GetComponent<Text>();
            refresh();
        }

        public void Sub(int amount)
        {
            score -= amount;
            refresh();
        }

        void refresh()
        {
            myText.text = " Your Score is " + score.ToString();
        }
    }
}
