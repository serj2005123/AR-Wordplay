using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    [SerializeField]
    public TMP_Text mText;
    [SerializeField]
    Animator mAnimator;
    [HideInInspector]
    public int time;
    [HideInInspector]
    public bool isGameEnded;
    Coroutine timeCoroutine;

 
    void Start()
    {
        isGameEnded = false;
        time = 60;
        timeCoroutine = StartCoroutine(Timer());
    }

    void Update()
    {
        if (isGameEnded)
        {
            var color = mText.color;
            mText.text = time.ToString();
            StopCoroutine(timeCoroutine);
            isGameEnded=false;
            mAnimator.enabled = false;
            mText.color = color;
            mText.GetComponentInParent<Image>().color = color;
            
        }
    }

    IEnumerator Timer()
    {
        mAnimator.Play("Time");
        while (time >= 0)
        {
            mText.text = time.ToString();
            time--;
            yield return new WaitForSeconds(1);
        }
    }


}
