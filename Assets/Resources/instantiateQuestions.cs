using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateQuestions : MonoBehaviour
{

    public string path = "Questions.xml";
    public GameObject canvas;
    public GameObject panelPrefab;
    public static int questionNumber = 0;
    public static bool questionsLoaded = false;

    public static Question[] qc;

    void Start()
    {
        if (!questionsLoaded)
        {
            QuestionsContainer questionsContainer = QuestionsContainer.Load(path);
            qc = new Question[questionsContainer.questions.Count];
            int i = 0;
            foreach (Question question in questionsContainer.questions)
            {
                qc[i] = question;
                //print(qc[i].question);
                i++;
            }
            questionsLoaded = true;
        }
    }

    public void instNewQuestion()
    { 
        if(questionNumber < qc.Length && QuestionPanelController.pressedButton == QuestionPanelController.correctButton)
        {
            GameObject newPanel = Instantiate(panelPrefab);
            newPanel.transform.SetParent(canvas.transform, false);

            int option = Random.Range(0, 4);
            Debug.Log("Option = " + option);

            if (option == 0)
            {
                QuestionPanelController controller = newPanel.GetComponent<QuestionPanelController>();
                controller.questionText.text = qc[questionNumber].question;
                controller.bt1Text.text = qc[questionNumber].correctAnswer;
                controller.bt2Text.text = qc[questionNumber].incorrectAnswers[0];
                controller.bt3Text.text = qc[questionNumber].incorrectAnswers[1];
                controller.bt4Text.text = qc[questionNumber].incorrectAnswers[2];
                QuestionPanelController.correctButton = 1;
            }
            if (option == 1)
            {
                QuestionPanelController controller = newPanel.GetComponent<QuestionPanelController>();
                controller.questionText.text = qc[questionNumber].question;
                controller.bt2Text.text = qc[questionNumber].correctAnswer;
                controller.bt3Text.text = qc[questionNumber].incorrectAnswers[0];
                controller.bt1Text.text = qc[questionNumber].incorrectAnswers[1];
                controller.bt4Text.text = qc[questionNumber].incorrectAnswers[2];
                QuestionPanelController.correctButton = 2;

            }
            if (option == 2)
            {
                QuestionPanelController controller = newPanel.GetComponent<QuestionPanelController>();
                controller.questionText.text = qc[questionNumber].question;
                controller.bt4Text.text = qc[questionNumber].correctAnswer;
                controller.bt3Text.text = qc[questionNumber].incorrectAnswers[0];
                controller.bt1Text.text = qc[questionNumber].incorrectAnswers[1];
                controller.bt2Text.text = qc[questionNumber].incorrectAnswers[2];
                QuestionPanelController.correctButton = 4;

            }
            if (option == 3)
            {
                QuestionPanelController controller = newPanel.GetComponent<QuestionPanelController>();
                controller.questionText.text = qc[questionNumber].question;
                controller.bt3Text.text = qc[questionNumber].correctAnswer;
                controller.bt1Text.text = qc[questionNumber].incorrectAnswers[0];
                controller.bt4Text.text = qc[questionNumber].incorrectAnswers[1];
                controller.bt2Text.text = qc[questionNumber].incorrectAnswers[2];
                QuestionPanelController.correctButton = 3;

            }

            questionNumber++;
        }
        
    }
}
