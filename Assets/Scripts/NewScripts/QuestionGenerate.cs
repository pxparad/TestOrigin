using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionGenerate : MonoBehaviour
{
    [Header("Set in Inspector")]
    public string FinalScene;
    public Text TextQuestion;
    public List<Question> QuestionsList = new List<Question>();
    public List<Button> buttons;
    
    Question question;

    void Start()
    {
        foreach (var item in QuestionsList)
        {
            GlobalLogic.Questions.Add(item);
        }
        ShowQuest();
    }

   
   public void ShowQuest()
    {
        int rand = Random.Range(0, QuestionsList.Count);
        question = QuestionsList[rand];
     
        QuestionsList.RemoveAt(rand);

        TextQuestion.text = question.TextQuestion;
        for (int i = 0; i < buttons.Count; i++)
        {
            buttons[i].GetComponentInChildren<Text>().text = question.Answers[i].Text;
        }

    }

    public void CheckAnswer(int index)
    {
        if (question.Answers[index].Value > 0)
        {
            GlobalLogic.CountTrueAnswers += question.Answers[index].Value;// ���������� � ������� ���������� ������� ��������. ��������� ������ ����� ���� ����� �����.
            print("Correct"); 
        }
        else print("incorrect");
        
        if (QuestionsList.Count > 0)
        {   
            ShowQuest();
        }
        else
        {
            SceneManager.LoadScene(FinalScene);
        }
        
    }
   
    public void TakeAnswer(int index)
    {
        //GlobalLogic. Abstract Result[index] +  question.Answers[index].ID;
    }
}
    