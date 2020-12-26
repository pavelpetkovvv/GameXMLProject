using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class instantiateQuestions : MonoBehaviour
{

    public string path = "Questions.xml";
    public GameObject canvas;
    public GameObject panelPrefab;
    public static int questionNumber = 0;
    public static bool questionsLoaded = false;
    QuestionsContainer questionsContainer;

    public static Question[] qc;


    void Start()
    {
        if (!questionsLoaded)
        {
            //loading questions from xml file
            questionsContainer = QuestionsContainer.Load(path);
            qc = new Question[questionsContainer.questions.Count];

            //puting the questions in array in order to acces them by index
            int i = 0;
            foreach (Question question in questionsContainer.questions)
            {
                qc[i] = question;
                i++;
            }
            questionsLoaded = true;
            instNewQuestion();
            Debug.Log("Start called");
        }
            
    }
    

    public void instNewQuestion()
    {
        Debug.Log("Question number = " + questionNumber);

        if (questionNumber >= qc.Length && QuestionPanelController.pressedButton == QuestionPanelController.correctButton)
        {
            //reseting static variables
            questionNumber = 0;
            questionsLoaded = false;
            QuestionPanelController.pressedButton = 1;
            QuestionPanelController.correctButton = 1;
            //instNewQuestion();

            //returning to main menu
            SceneManager.LoadScene("MainMenu");
        }
        if (questionNumber < qc.Length && QuestionPanelController.pressedButton == QuestionPanelController.correctButton)
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
