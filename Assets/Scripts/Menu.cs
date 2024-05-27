using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] public GameObject EtoA;
    [SerializeField] public GameObject RtoA;
    [SerializeField] Image Circleimage;



    public void EnglishToArmenian()
    {
        StatePrefabController.prefab = EtoA;
    }
    public void RussianToArmenian()
    {
        StatePrefabController.prefab = RtoA;
    }
    public void Exit()
    {
        Application.Quit();
    }

    void Update()
    {
       if(Circleimage.fillAmount == 1)
        {
            SceneManager.LoadScene(1);
        }
    }
}
