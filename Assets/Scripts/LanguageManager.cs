using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LanguageManager : MonoBehaviour
{
    public enum Language
    {
        English,
        Armenian
    }
    public static Language currentLanguage = Language.Armenian;

    [SerializeField] private Sprite[] englishButtonSprites;
    [SerializeField] private string[] englishTexts;
    [SerializeField] private Sprite[] armenianButtonSprites;
    [SerializeField] private string[] armenianTexts;
    [SerializeField] private Image[] menuButtons;
    [SerializeField] private TMP_Text[] menuTexts;

    private const string LanguageKey = "SelectedLanguage";

    private void Start()
    {
        if (PlayerPrefs.HasKey(LanguageKey))
        {
            string savedLanguage = PlayerPrefs.GetString(LanguageKey);
            currentLanguage = (Language)System.Enum.Parse(typeof(Language), savedLanguage);
        }

        UpdateUI();
    }

    public void SetLanguage(Language newLanguage)
    {
        currentLanguage = newLanguage;
        UpdateUI();

        PlayerPrefs.SetString(LanguageKey, currentLanguage.ToString());
        PlayerPrefs.Save();
    }

    private void UpdateUI()
    {
        Sprite[] buttonSprites = (currentLanguage == Language.English) ? englishButtonSprites : armenianButtonSprites;
        string[] texts = (currentLanguage == Language.English) ? englishTexts : armenianTexts;

        for (int i = 0; i < menuButtons.Length; i++)
        {
            menuButtons[i].sprite = buttonSprites[i];
        }

        for (int i = 0; i < menuTexts.Length; i++)
        {
            menuTexts[i].text = texts[i];
        }
    }

    public void SetEnglishLanguage()
    {
        SetLanguage(Language.English);
    }

    public void SetArmenianLanguage()
    {
        SetLanguage(Language.Armenian);
    }
}
