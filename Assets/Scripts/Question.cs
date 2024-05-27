using System.Collections.Generic;

[System.Serializable]
public class Question
{
    public string Text;
    public List<string> Choices;
    public int CorrectChoiceIndex;

    public Question(string text, List<string> choices, int correctChoiceIndex)
    {
        Text = text;
        Choices = choices;
        CorrectChoiceIndex = correctChoiceIndex;
    }
}
