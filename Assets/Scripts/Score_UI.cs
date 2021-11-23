using UnityEngine;
using UnityEngine.UI;
using System.Collections;


namespace TMPro.Examples
{

    public class Score_UI : MonoBehaviour
    {

        public float Score;

        private GameObject Banana;

        Text UI_Score;

        private TextMeshPro m_textMeshPro;

        private const string label = "The <#0050FF>count is: </color>{0:2}";
        private float m_frame;


        void Start()
        {

            UI_Score = gameObject.GetComponent<Text>();

            m_textMeshPro = gameObject.AddComponent<TextMeshPro>();

            m_textMeshPro.autoSizeTextContainer = true;

            m_textMeshPro.fontSize = 48;

            m_textMeshPro.alignment = TextAlignmentOptions.Center;

            m_textMeshPro.enableWordWrapping = false;

        }


        void Update()
        {
            m_textMeshPro.SetText(label, m_frame % 1000);
            m_frame += 1 * Time.deltaTime;

        }

        public void AddScore(int EnemyScore)
        {
            Score += EnemyScore;

            UI_Score.text = Score.ToString();

            if (Score == 50)
            {
                Banana = GameObject.FindGameObjectWithTag("Status");
                Banana.GetComponent<Status>().Text_Changing(2);
            }
        }


    }
}

