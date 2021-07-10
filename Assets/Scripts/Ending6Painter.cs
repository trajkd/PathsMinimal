using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Ending6Painter : MonoBehaviour
{
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    [SerializeField]GameObject continueButton;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        SceneManager.UnloadScene("Chapter6");
        highlightsTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["You went back to the day the lake accident happened..."] = "You went back to the day the lake accident happened...",
                ["...you went directly to the lake."] = "...you went directly to the lake.",
                ["...you had to lock your past self before going to the lake."] = "...you had to lock your past self before going to the lake.",
                ["...you failed at saving your brothers."] = "...you failed at saving your brothers."
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["You went back to the day the lake accident happened..."] = "Sei tornata al giorno in cui successe l'incidente al lago...",
                ["...you went directly to the lake."] = "...sei andata subito al lago.",
                ["...you had to lock your past self before going to the lake."] = "...hai dovuto chiudere a chiave te stessa del passato prima di andare al lago.",
                ["...you failed at saving your brothers."] = "...non sei riuscita a salvare i tuoi fratelli."
            }
        };
        GameObject.Find("Ending title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        GameObject narratortextgo = Instantiate(narrator) as GameObject;
        narratortextgo.SetActive(false);
        narratortextgo.transform.parent = gameObject.transform;
        Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["You went back to the day the lake accident happened..."];
        Image narratortextimage = narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
        narratortextimage.color = new Color(narratortextimage.color.r, narratortextimage.color.g, narratortextimage.color.b, 0f);
        TMP_Text narratortexttext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
        narratortexttext.color = new Color(narratortexttext.color.r, narratortexttext.color.g, narratortexttext.color.b, 0f);
        narratortextgo.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        LeanTween.alpha(narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
        narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);

        if (PlayerPrefs.GetString("lock") == "You went directly to the lake") {
            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you went directly to the lake."];
            Image narratortext02image = narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext02image.color = new Color(narratortext02image.color.r, narratortext02image.color.g, narratortext02image.color.b, 0f);
            TMP_Text narratortext02text = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext02text.color = new Color(narratortext02text.color.r, narratortext02text.color.g, narratortext02text.color.b, 0f);
            narratortext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimagego = Instantiate(narratorWithImage) as GameObject;
            narratorimagego.SetActive(false);
            narratorimagego.transform.parent = gameObject.transform;
            Transform narratorimage = narratorimagego.transform.Find("Textbox container/Narrator text/Image");
            narratorimage.GetComponent<Image>().preserveAspect = true;
            narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap5-1");
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimagego.SetActive(true);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("lock") == "You had to lock your past self before going to the lake") {
            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you had to lock your past self before going to the lake."];
            Image narratortext02image = narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext02image.color = new Color(narratortext02image.color.r, narratortext02image.color.g, narratortext02image.color.b, 0f);
            TMP_Text narratortext02text = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext02text.color = new Color(narratortext02text.color.r, narratortext02text.color.g, narratortext02text.color.b, 0f);
            narratortext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimagego = Instantiate(narratorWithImage) as GameObject;
            narratorimagego.SetActive(false);
            narratorimagego.transform.parent = gameObject.transform;
            Transform narratorimage = narratorimagego.transform.Find("Textbox container/Narrator text/Image");
            narratorimage.GetComponent<Image>().preserveAspect = true;
            narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap5-2-"+PlayerPrefs.GetString("type_of_lock","1"));
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimagego.SetActive(true);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        GameObject narratortext03go = Instantiate(narrator) as GameObject;
        narratortext03go.SetActive(false);
        narratortext03go.transform.parent = gameObject.transform;
        Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you failed at saving your brothers."];
        Image narratortext03image = narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
        narratortext03image.color = new Color(narratortext03image.color.r, narratortext03image.color.g, narratortext03image.color.b, 0f);
        TMP_Text narratortext03text = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
        narratortext03text.color = new Color(narratortext03text.color.r, narratortext03text.color.g, narratortext03text.color.b, 0f);
        narratortext03go.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        LeanTween.alpha(narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
        narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);

        GameObject narratorimage02go = Instantiate(narratorWithImage) as GameObject;
        narratorimage02go.SetActive(false);
        narratorimage02go.transform.parent = gameObject.transform;
        Transform narratorimage02 = narratorimage02go.transform.Find("Textbox container/Narrator text/Image");
        narratorimage02.GetComponent<Image>().preserveAspect = true;
        narratorimage02.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap5-3");
        LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
        narratorimage02go.SetActive(true);
        LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
        LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
        yield return new WaitForSeconds(0.6f);
        
        continueButton.SetActive(true);
        LeanTween.alpha(continueButton.GetComponent<RectTransform>(), 1f, 0.4f);
    }
}