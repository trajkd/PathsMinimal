using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeToggler : MonoBehaviour
{
    [SerializeField]GameObject themeToggler;
    [SerializeField]GameObject lightTheme;
    [SerializeField]GameObject nightTheme;
    void Start()
    {
        if (PlayerPrefs.GetString("Theme", "Light") == "Light") {
            lightTheme.SetActive(true);
            nightTheme.SetActive(false);
            themeToggler.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/sole");
        } else {
            nightTheme.SetActive(true);
            lightTheme.SetActive(false);
            themeToggler.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/luna");
        }
        themeToggler.GetComponent<Button>().onClick.AddListener(() => ToggleTheme());
    }
    void ToggleTheme()
    {
        if (PlayerPrefs.GetString("Theme") == "Light" || !PlayerPrefs.HasKey("Theme")) {
            PlayerPrefs.SetString("Theme", "Night");
            nightTheme.SetActive(true);
            lightTheme.SetActive(false);
            themeToggler.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/luna");
        } else {
            PlayerPrefs.SetString("Theme", "Light");
            lightTheme.SetActive(true);
            nightTheme.SetActive(false);
            themeToggler.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/sole");
        }
    }
}
