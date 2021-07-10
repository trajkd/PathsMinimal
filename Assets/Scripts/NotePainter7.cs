using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NotePainter7 : MonoBehaviour
{
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        highlightsTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["You went back to your time to talk to Grandma..."] = "You went back to your time to talk to Grandma...",
                ["You went back to the 70s to talk to Grandma..."] = "You went back to the 70s to talk to Grandma...",
                ["...you and Grandma analyzed the reasons why you failed."] = "...you and Grandma analyzed the reasons why you failed.",
                ["...you made a plan to save your brothers."] = "...you made a plan to save your brothers.",
                ["...you chose the Christmas memory."] = "...you chose the Christmas memory.",
                ["...you chose the twins' birth memory."] = "...you chose the twins' birth memory."
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["You went back to your time to talk to Grandma..."] = "Sei tornata al tuo tempo per parlare con la nonna...",
                ["You went back to the 70s to talk to Grandma..."] = "Sei tornata agli anni 70 per parlare con la nonna...",
                ["...you and Grandma analyzed the reasons why you failed."] = "...tu e la nonna avete analizzato le ragioni per cui hai fallito.",
                ["...you made a plan to save your brothers."] = "...hai fatto un piano per salvare i tuoi fratelli.",
                ["...you chose the Christmas memory."] = "...hai scelto la memoria di Natale.",
                ["...you chose the twins' birth memory."] = "...hai scelto la memoria della nascita dei gemelli."
            }
        };
        GameObject.Find("Ending title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        if (PlayerPrefs.GetInt("grandma_dead") == 0) {
            GameObject narratortextgo = Instantiate(narrator) as GameObject;
            narratortextgo.SetActive(false);
            narratortextgo.transform.parent = gameObject.transform;
            Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["You went back to your time to talk to Grandma..."];
            Image narratortextimage = narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortextimage.color = new Color(narratortextimage.color.r, narratortextimage.color.g, narratortextimage.color.b, 0f);
            TMP_Text narratortexttext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortexttext.color = new Color(narratortexttext.color.r, narratortexttext.color.g, narratortexttext.color.b, 0f);
            narratortextgo.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else {
            GameObject narratortextgo = Instantiate(narrator) as GameObject;
            narratortextgo.SetActive(false);
            narratortextgo.transform.parent = gameObject.transform;
            Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["You went back to the 70s to talk to Grandma..."];
            Image narratortextimage = narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortextimage.color = new Color(narratortextimage.color.r, narratortextimage.color.g, narratortextimage.color.b, 0f);
            TMP_Text narratortexttext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortexttext.color = new Color(narratortexttext.color.r, narratortexttext.color.g, narratortexttext.color.b, 0f);
            narratortextgo.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        GameObject narratortext02go = Instantiate(narrator) as GameObject;
        narratortext02go.SetActive(false);
        narratortext02go.transform.parent = gameObject.transform;
        Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you and Grandma analyzed the reasons why you failed."];
        Image narratortext02image = narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
        narratortext02image.color = new Color(narratortext02image.color.r, narratortext02image.color.g, narratortext02image.color.b, 0f);
        TMP_Text narratortext02text = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
        narratortext02text.color = new Color(narratortext02text.color.r, narratortext02text.color.g, narratortext02text.color.b, 0f);
        narratortext02go.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        LeanTween.alpha(narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
        narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);

        GameObject narratortext03go = Instantiate(narrator) as GameObject;
        narratortext03go.SetActive(false);
        narratortext03go.transform.parent = gameObject.transform;
        Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you made a plan to save your brothers."];
        Image narratortext03image = narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
        narratortext03image.color = new Color(narratortext03image.color.r, narratortext03image.color.g, narratortext03image.color.b, 0f);
        TMP_Text narratortext03text = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
        narratortext03text.color = new Color(narratortext03text.color.r, narratortext03text.color.g, narratortext03text.color.b, 0f);
        narratortext03go.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        LeanTween.alpha(narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
        narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);

        if (PlayerPrefs.GetString("memory") == "You chose the Christmas memory") {
            GameObject narratortext04go = Instantiate(narrator) as GameObject;
            narratortext04go.SetActive(false);
            narratortext04go.transform.parent = gameObject.transform;
            Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you chose the Christmas memory."];
            Image narratortext04image = narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext04image.color = new Color(narratortext04image.color.r, narratortext04image.color.g, narratortext04image.color.b, 0f);
            TMP_Text narratortext04text = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext04text.color = new Color(narratortext04text.color.r, narratortext04text.color.g, narratortext04text.color.b, 0f);
            narratortext04go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("memory") == "You chose the twins birth memory") {
            GameObject narratortext04go = Instantiate(narrator) as GameObject;
            narratortext04go.SetActive(false);
            narratortext04go.transform.parent = gameObject.transform;
            Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you chose the twins' birth memory."];
            Image narratortext04image = narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext04image.color = new Color(narratortext04image.color.r, narratortext04image.color.g, narratortext04image.color.b, 0f);
            TMP_Text narratortext04text = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext04text.color = new Color(narratortext04text.color.r, narratortext04text.color.g, narratortext04text.color.b, 0f);
            narratortext04go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }
    }
}