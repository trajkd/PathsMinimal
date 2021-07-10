using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Ending1Painter : MonoBehaviour
{
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    [SerializeField]GameObject continueButton;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        SceneManager.UnloadScene("Chapter1");
        highlightsTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["One day you invited Dave at home and..."] = "One day you invited Dave at home and...",
                ["You refused Dave’s advances"] = "...you refused Dave’s advances.",
                ["You accepted Dave’s advances"] = "...you accepted Dave’s advances.",
                ["You stepped in against your mother"] = "...you stepped in against your mother.",
                ["You didn’t step in against your mother"] = "...you didn’t step in against your mother."
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["One day you invited Dave at home and..."] = "Un giorno hai invitato Dave a casa e...",
                ["You refused Dave’s advances"] = "...hai rifiutato le proposte amorose di Dave.",
                ["You accepted Dave’s advances"] = "...hai accettato le proposte amorose di Dave.",
                ["You stepped in against your mother"] = "...sei intervenuta contro tua mamma.",
                ["You didn’t step in against your mother"] = "...non sei intervenuta contro tua mamma."
            }
        };
        GameObject.Find("Ending title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);

        GameObject narratortextgo = Instantiate(narrator) as GameObject;
        narratortextgo.SetActive(false);
        narratortextgo.transform.parent = gameObject.transform;
        Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["One day you invited Dave at home and..."];
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
        narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap0-5");
        LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
        narratorimagego.SetActive(true);
        LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
        LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
        yield return new WaitForSeconds(0.6f);

        GameObject narratortext2go = Instantiate(narrator) as GameObject;
        narratortext2go.SetActive(false);
        narratortext2go.transform.parent = gameObject.transform;
        Transform narratortext2 = narratortext2go.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext2.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage][PlayerPrefs.GetString("daves_advances")];
        Image narratortext2image = narratortext2go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
        narratortext2image.color = new Color(narratortext2image.color.r, narratortext2image.color.g, narratortext2image.color.b, 0f);
        TMP_Text narratortext2text = narratortext2go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
        narratortext2text.color = new Color(narratortext2text.color.r, narratortext2text.color.g, narratortext2text.color.b, 0f);
        narratortext2go.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        LeanTween.alpha(narratortext2go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
        narratortext2go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);

        GameObject narratortext3go = Instantiate(narrator) as GameObject;
        narratortext3go.SetActive(false);
        narratortext3go.transform.parent = gameObject.transform;
        Transform narratortext3 = narratortext3go.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext3.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage][PlayerPrefs.GetString("reaction_with_mom")];
        Image narratortext3image = narratortext3go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
        narratortext3image.color = new Color(narratortext3image.color.r, narratortext3image.color.g, narratortext3image.color.b, 0f);
        TMP_Text narratortext3text = narratortext3go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
        narratortext3text.color = new Color(narratortext3text.color.r, narratortext3text.color.g, narratortext3text.color.b, 0f);
        narratortext3go.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        LeanTween.alpha(narratortext3go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
        narratortext3go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);

        continueButton.SetActive(true);
        LeanTween.alpha(continueButton.GetComponent<RectTransform>(), 1f, 0.4f);
    }
}
