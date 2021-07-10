using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Ending2Painter : MonoBehaviour
{
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    [SerializeField]GameObject continueButton;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        SceneManager.UnloadScene("Chapter2");
        highlightsTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["On your way to the grandparents' house..."] = "On your way to the grandparents' house...",
                ["On your way to Grandpa's house..."] = "On your way to Grandpa's house...",
                ["...you decided to listen to your father."] = "...you decided to listen to your father.",
                ["...you had a sarcastic attitude towards your family."] = "...you had a sarcastic attitude towards your family.",
                ["...you thought about your Grandma and her gift."] = "...you thought about your Grandma and her gift."
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["On your way to the grandparents' house..."] = "In viaggio verso la casa dei nonni...",
                ["On your way to Grandpa's house..."] = "In viaggio verso la casa del nonno...",
                ["...you decided to listen to your father."] = "...ti sei decisa ad ascoltare tuo padre.",
                ["...you had a sarcastic attitude towards your family."] = "...hai avuto un atteggiamento sarcastico verso la tua famiglia.",
                ["...you thought about your Grandma and her gift."] = "...hai pensato alla nonna e al suo regalo."
            }
        };
        GameObject.Find("Ending title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        GameObject narratortextgo = Instantiate(narrator) as GameObject;
        narratortextgo.SetActive(false);
        narratortextgo.transform.parent = gameObject.transform;
        Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        if (PlayerPrefs.GetInt("grandma_dead") == 0) {
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["On your way to the grandparents' house..."];
        } else {
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["On your way to Grandpa's house..."];
        }
        Image narratortextimage = narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
        narratortextimage.color = new Color(narratortextimage.color.r, narratortextimage.color.g, narratortextimage.color.b, 0f);
        TMP_Text narratortexttext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
        narratortexttext.color = new Color(narratortexttext.color.r, narratortexttext.color.g, narratortexttext.color.b, 0f);
        narratortextgo.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        LeanTween.alpha(narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
        narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        GameObject narratorimagego = Instantiate(narratorWithImage) as GameObject;
        narratorimagego.SetActive(false);
        narratorimagego.transform.parent = gameObject.transform;
        Transform narratorimage = narratorimagego.transform.Find("Textbox container/Narrator text/Image");
        narratorimage.GetComponent<Image>().preserveAspect = true;
        narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap1-1");
        LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
        narratorimagego.SetActive(true);
        LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
        LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
        yield return new WaitForSeconds(0.6f);

        if (PlayerPrefs.GetString("listen_to_dad") == "You decided to listen to your father") {
            GameObject narratortext01go = Instantiate(narrator) as GameObject;
            narratortext01go.SetActive(false);
            narratortext01go.transform.parent = gameObject.transform;
            Transform narratortext01 = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext01.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you decided to listen to your father."];
            Image narratortext01image = narratortext01go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext01image.color = new Color(narratortext01image.color.r, narratortext01image.color.g, narratortext01image.color.b, 0f);
            TMP_Text narratortext01text = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext01text.color = new Color(narratortext01text.color.r, narratortext01text.color.g, narratortext01text.color.b, 0f);
            narratortext01go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext01go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        if (PlayerPrefs.GetString("sarcastic_attitude") == "You had a sarcastic attitude towards your family") {
            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you had a sarcastic attitude towards your family."];
            Image narratortext02image = narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext02image.color = new Color(narratortext02image.color.r, narratortext02image.color.g, narratortext02image.color.b, 0f);
            TMP_Text narratortext02text = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext02text.color = new Color(narratortext02text.color.r, narratortext02text.color.g, narratortext02text.color.b, 0f);
            narratortext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        GameObject narratortext2go = Instantiate(narrator) as GameObject;
        narratortext2go.SetActive(false);
        narratortext2go.transform.parent = gameObject.transform;
        Transform narratortext2 = narratortext2go.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext2.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you thought about your Grandma and her gift."];
        Image narratortext2image = narratortext2go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
        narratortext2image.color = new Color(narratortext2image.color.r, narratortext2image.color.g, narratortext2image.color.b, 0f);
        TMP_Text narratortext2text = narratortext2go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
        narratortext2text.color = new Color(narratortext2text.color.r, narratortext2text.color.g, narratortext2text.color.b, 0f);
        narratortext2go.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        LeanTween.alpha(narratortext2go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
        narratortext2go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        GameObject narratorimage2go = Instantiate(narratorWithImage) as GameObject;
        narratorimage2go.SetActive(false);
        narratorimage2go.transform.parent = gameObject.transform;
        Transform narratorimage2 = narratorimage2go.transform.Find("Textbox container/Narrator text/Image");
        narratorimage2.GetComponent<Image>().preserveAspect = true;
        narratorimage2.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap1-2");
        LeanTween.alpha(narratorimage2go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
        narratorimage2go.SetActive(true);
        LeanTween.alpha(narratorimage2go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
        LeanTween.alpha(narratorimage2go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
        yield return new WaitForSeconds(0.6f);
        
        continueButton.SetActive(true);
        LeanTween.alpha(continueButton.GetComponent<RectTransform>(), 1f, 0.4f);
    }
}