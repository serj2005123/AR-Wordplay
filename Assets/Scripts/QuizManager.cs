using System.Collections.Generic;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.EventSystems;
using System.Linq;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour 
{
    public string Language;
    public TextMeshPro questionText;
    [SerializeField]
    TMP_Text Points;
    [SerializeField]
    TMP_Text Lifes;
    [SerializeField]
    TMP_Text End;
    [SerializeField]
    Time time;
    [SerializeField]
    Toggle SoundToggle;
    [SerializeField] AudioSource CorrectSound;
    [SerializeField] AudioSource WrongSound;
    int points_count = 0;
    int lifes_count = 3;
    public TextMeshPro[] answerObjects;

    [SerializeField] GameObject Prefab;
    [SerializeField] LanguageList languageList;

    private List<Question> questions;
    private int currentQuestionIndex = 0;
    private List<int> RandomIndexes = new List<int>();

    int index;
    int Rand;


    private void Start()
    {
        Language = LanguageManager.currentLanguage.ToString();
        Debug.Log(Language);
        if (Prefab.tag == "EnglishToArmenian")
        {
            questions = languageList.EtoA;
        }
        else if(Prefab.tag == "RussianToArmenian")
        {
            questions = languageList.RtoA;
        }

        index = 0;
        Points.text = points_count.ToString();
        Lifes.text = lifes_count.ToString();
        
        for (int j = 1; j < questions.Count; j++)
        {
            
            Rand = Random.Range(0, questions.Count);

            while (RandomIndexes.Contains(Rand))
            {
                Rand = Random.Range(0, questions.Count);
            }
            RandomIndexes.Add(Rand);
        }


        currentQuestionIndex = RandomIndexes[index];

        ShowQuestion(currentQuestionIndex);
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
    
    private void ShowQuestion(int index)
    {
        Question question = questions[index];
        questionText.text = question.Text;

        for (int i = 0; i < question.Choices.Count; i++)
        {
            answerObjects[i].text = question.Choices[i];
        }
    }

    public void CheckAnswer(Collider collider)
    {
        Question currentQuestion = questions[currentQuestionIndex];
        Collider correctCollider = answerObjects[currentQuestion.CorrectChoiceIndex].GetComponent<Collider>();
        if (collider.name == correctCollider.name)
        {
            points_count++;
            Points.text = points_count.ToString();
            if (SoundToggle.isOn)
            {
                CorrectSound.Play();
            }
        }
        else
        {
            lifes_count--;
            Lifes.text = lifes_count.ToString();
            if (SoundToggle.isOn)
            {
                WrongSound.Play();
            }
        }

        if (lifes_count == 0)
        {
            End.gameObject.SetActive(true);
            time.isGameEnded = true;
            if (Language == "English")
            {
                End.text = "GAME OVER";
            }
            else End.text = "Դուք Պարտվեցիք";
        }
        if (points_count == 10)
        {
            End.gameObject.SetActive(true);
            time.isGameEnded = true;
            if (Language == "English")
            {
                End.text = "YOU WIN";
            }
            else End.text = "Դուք Հաղթեցիք";
        }



        index++;
        currentQuestionIndex = RandomIndexes[index];


        if (currentQuestionIndex < questions.Count)
        {
            ShowQuestion(currentQuestionIndex);
        }
    }
    private void Update()
    {
        
        if (time.time == 0)
        {
            End.gameObject.SetActive(true);
            time.isGameEnded = true;
            if (Language == "English")
            {
                End.text = "GAME OVER";
            }
            else End.text = "Դուք Պարտվեցիք";
        }


    }
}
