using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public static class GlobalLogic
{
    static public List<Question> Questions = new List<Question>();
    static public int CountTrueAnswers;
}

[System.Serializable]
public class Question
{
    public string TextQuestion;
    public List<Answer> Answers;
}
[System.Serializable]
public class Answer
{
    public string Text;
    public int Value; // � ����������� �� ���� ����������� (����� ��� ���������) ������������ ID ��� Value, ��� ����������.
}