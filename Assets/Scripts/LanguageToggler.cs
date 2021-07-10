using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LanguageToggler : MonoBehaviour
{
    [SerializeField]GameObject englishToggler;
    [SerializeField]GameObject italianToggler;
    void Start()
    {
        if (PlayerPrefs.GetString("Language", "English") == "Italiano") {
            englishToggler.SetActive(false);
            italianToggler.SetActive(true);
        }
        englishToggler.GetComponent<Button>().onClick.AddListener(() => SetLanguage("Italiano"));
        italianToggler.GetComponent<Button>().onClick.AddListener(() => SetLanguage("English"));
    }
    void SetLanguage(string languageToSwitchTo) {
        TextLocalizer.CurrentLanguage = languageToSwitchTo;
        PlayerPrefs.SetString("Language", languageToSwitchTo);
        if (languageToSwitchTo == "English") {
            italianToggler.SetActive(false);
            englishToggler.SetActive(true);
        } 
        else if (languageToSwitchTo == "Italiano") {
            englishToggler.SetActive(false);
            italianToggler.SetActive(true);
        }
        GameObject.Find("Time").GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue("time");
        GameObject.Find("Date").GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue("date");
    }
}
