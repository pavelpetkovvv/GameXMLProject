using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsLoader : MonoBehaviour
{
    public string path = "Questions.xml";

    // Start is called before the first frame update
    void Start()
    {
        QuestionsContainer qc = QuestionsContainer.Load(path);
        foreach (Question question in qc.questions)
        {
            print("Question:");
            print(question.question);
            print("Correct answer:");
            print(question.correctAnswer);

            print("Incorrrect answers: ");
            foreach(string st in question.incorrectAnswers)
            {
                print(st);
            }
        }
    }

}
