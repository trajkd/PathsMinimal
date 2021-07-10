using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CreditsPainter : MonoBehaviour
{
    [SerializeField]GameObject continueButton;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        
        GameObject.Find("Credits title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);

        continueButton.SetActive(true);
        LeanTween.alpha(continueButton.GetComponent<RectTransform>(), 1f, 0.4f);
    }
}