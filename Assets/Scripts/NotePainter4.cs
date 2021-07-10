using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NotePainter4 : MonoBehaviour
{
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        highlightsTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["At the grandparents' house..."] = "At the grandparents' house...",
                ["At Grandpa's house..."] = "At Grandpa's house...",
                ["...you looked at your brothers’ birth picture."] = "...you looked at your brothers’ birth picture.",
                ["...you looked at your brothers’ birthday picture."] = "...you looked at your brothers’ birthday picture.",
                ["...you looked at Grandma’s picture."] = "...you looked at Grandma’s picture.",
                ["...you played a snowball game with the twins."] = "...you played a snowball game with the twins.",
                ["...you convinced the twins to go to the lake."] = "...you convinced the twins to go to the lake.",
                ["...you saw the twins going to the lake from the window."] = "...you saw the twins going to the lake from the window.",
                ["...you saw that the ice covering the lake had cracked and the twins were nowhere to be seen."] = "...you saw that the ice covering the lake had cracked and the twins were nowhere to be seen.",
                ["At the lake..."] = "At the lake...",
                ["...the twins drowned..."] = "...the twins drowned...",
                ["...but you are safe."] = "...but you are safe.",
                ["...Tommy drowned..."] = "...Tommy drowned...",
                ["...but you saved Nicholas."] = "...but you saved Nicholas.",
                ["...Nicholas drowned..."] = "...Nicholas drowned...",
                ["...but you saved Tommy."] = "...but you saved Tommy."
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["On your way to the grandparents' house..."] = "In viaggio verso la casa dei nonni...",
                ["On your way to Grandpa's house..."] = "In viaggio verso la casa del nonno...",
                ["...you looked at your brothers’ birth picture."] = "...hai guardato la foto della nascita dei tuoi fratelli.",
                ["...you looked at your brothers’ birthday picture."] = "...hai guardato la foto del compleanno dei tuoi fratelli.",
                ["...you looked at Grandma’s picture."] = "...hai guardato la foto della nonna.",
                ["...you played a snowball game with the twins."] = "...hai giocato a palle di neve con i gemelli.",
                ["...you convinced the twins to go to the lake."] = "...hai convinto i gemelli ad andare al lago.",
                ["...you saw the twins going to the lake from the window."] = "...hai visto i gemelli andare al lago dalla finestra.",
                ["...you saw that the ice covering the lake had cracked and the twins were nowhere to be seen."] = "...hai visto che il ghiaccio che copriva il lago si è rotto e i gemelli non si trovavano da nessuna parte.",
                ["At the lake..."] = "Al lago...",
                ["...the twins drowned..."] = "...i gemelli sono affogati...",
                ["...but you are safe."] = "...ma tu sei salva.",
                ["...Tommy drowned..."] = "...Tommy è affogato...",
                ["...but you saved Nicholas."] = "...ma hai salvato Nicholas.",
                ["...Nicholas drowned..."] = "...Nicholas è affogato...",
                ["...but you saved Tommy."] = "...ma hai salvato Tommy."
            }
        };
        GameObject.Find("Ending title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        GameObject narratortextgo = Instantiate(narrator) as GameObject;
        narratortextgo.SetActive(false);
        narratortextgo.transform.parent = gameObject.transform;
        Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        if (PlayerPrefs.GetInt("grandma_dead") == 0) {
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["At the grandparents' house..."];
        } else {
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["At Grandpa's house..."];
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

        if (PlayerPrefs.GetString("look_at_picture") == "You looked at your brothers’ birth picture") {
            GameObject narratortext01go = Instantiate(narrator) as GameObject;
            narratortext01go.SetActive(false);
            narratortext01go.transform.parent = gameObject.transform;
            Transform narratortext01 = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext01.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you looked at your brothers’ birth picture."];
            Image narratortext01image = narratortext01go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext01image.color = new Color(narratortext01image.color.r, narratortext01image.color.g, narratortext01image.color.b, 0f);
            TMP_Text narratortext01text = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext01text.color = new Color(narratortext01text.color.r, narratortext01text.color.g, narratortext01text.color.b, 0f);
            narratortext01go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext01go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimagego = Instantiate(narratorWithImage) as GameObject;
            narratorimagego.SetActive(false);
            narratorimagego.transform.parent = gameObject.transform;
            Transform narratorimage = narratorimagego.transform.Find("Textbox container/Narrator text/Image");
            narratorimage.GetComponent<Image>().preserveAspect = true;
            narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-1");
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimagego.SetActive(true);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("look_at_picture") == "You looked at your brothers’ birthday picture") {
            GameObject narratortext01go = Instantiate(narrator) as GameObject;
            narratortext01go.SetActive(false);
            narratortext01go.transform.parent = gameObject.transform;
            Transform narratortext01 = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext01.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you looked at your brothers’ birthday picture."];
            Image narratortext01image = narratortext01go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext01image.color = new Color(narratortext01image.color.r, narratortext01image.color.g, narratortext01image.color.b, 0f);
            TMP_Text narratortext01text = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext01text.color = new Color(narratortext01text.color.r, narratortext01text.color.g, narratortext01text.color.b, 0f);
            narratortext01go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext01go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimagego = Instantiate(narratorWithImage) as GameObject;
            narratorimagego.SetActive(false);
            narratorimagego.transform.parent = gameObject.transform;
            Transform narratorimage = narratorimagego.transform.Find("Textbox container/Narrator text/Image");
            narratorimage.GetComponent<Image>().preserveAspect = true;
            narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-2");
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimagego.SetActive(true);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("look_at_picture") == "You looked at Grandma’s picture") {
            GameObject narratortext01go = Instantiate(narrator) as GameObject;
            narratortext01go.SetActive(false);
            narratortext01go.transform.parent = gameObject.transform;
            Transform narratortext01 = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext01.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you looked at Grandma’s picture."];
            Image narratortext01image = narratortext01go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext01image.color = new Color(narratortext01image.color.r, narratortext01image.color.g, narratortext01image.color.b, 0f);
            TMP_Text narratortext01text = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext01text.color = new Color(narratortext01text.color.r, narratortext01text.color.g, narratortext01text.color.b, 0f);
            narratortext01go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext01go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimagego = Instantiate(narratorWithImage) as GameObject;
            narratorimagego.SetActive(false);
            narratorimagego.transform.parent = gameObject.transform;
            Transform narratorimage = narratorimagego.transform.Find("Textbox container/Narrator text/Image");
            narratorimage.GetComponent<Image>().preserveAspect = true;
            narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-3");
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimagego.SetActive(true);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        if (PlayerPrefs.GetString("snowball_game") == "You played a snowball game with the twins") {
            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you played a snowball game with the twins."];
            Image narratortext02image = narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext02image.color = new Color(narratortext02image.color.r, narratortext02image.color.g, narratortext02image.color.b, 0f);
            TMP_Text narratortext02text = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext02text.color = new Color(narratortext02text.color.r, narratortext02text.color.g, narratortext02text.color.b, 0f);
            narratortext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage12go = Instantiate(narratorWithImage) as GameObject;
            narratorimage12go.SetActive(false);
            narratorimage12go.transform.parent = gameObject.transform;
            Transform narratorimage12 = narratorimage12go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage12.GetComponent<Image>().preserveAspect = true;
            narratorimage12.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-4");
            LeanTween.alpha(narratorimage12go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage12go.SetActive(true);
            LeanTween.alpha(narratorimage12go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage12go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        if (PlayerPrefs.GetString("twins_on_the_lake") == "You convinced the twins to go to the lake") {
            GameObject narratortext03go = Instantiate(narrator) as GameObject;
            narratortext03go.SetActive(false);
            narratortext03go.transform.parent = gameObject.transform;
            Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you convinced the twins to go to the lake."];
            Image narratortext03image = narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext03image.color = new Color(narratortext03image.color.r, narratortext03image.color.g, narratortext03image.color.b, 0f);
            TMP_Text narratortext03text = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext03text.color = new Color(narratortext03text.color.r, narratortext03text.color.g, narratortext03text.color.b, 0f);
            narratortext03go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("twins_on_the_lake") == "You saw the twins going to the lake from the window") {
            GameObject narratortext03go = Instantiate(narrator) as GameObject;
            narratortext03go.SetActive(false);
            narratortext03go.transform.parent = gameObject.transform;
            Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you saw the twins going to the lake from the window."];
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
            narratorimage02.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-5-2");
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage02go.SetActive(true);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("twins_on_the_lake") == "You saw that the ice covering the lake had cracked and the twins were nowhere to be seen") {
            GameObject narratortext03go = Instantiate(narrator) as GameObject;
            narratortext03go.SetActive(false);
            narratortext03go.transform.parent = gameObject.transform;
            Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you saw that the ice covering the lake had cracked and the twins were nowhere to be seen."];
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
            narratorimage02.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-5-1");
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage02go.SetActive(true);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        GameObject narratortext04go = Instantiate(narrator) as GameObject;
        narratortext04go.SetActive(false);
        narratortext04go.transform.parent = gameObject.transform;
        Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["At the lake..."];
        Image narratortext04image = narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
        narratortext04image.color = new Color(narratortext04image.color.r, narratortext04image.color.g, narratortext04image.color.b, 0f);
        TMP_Text narratortext04text = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
        narratortext04text.color = new Color(narratortext04text.color.r, narratortext04text.color.g, narratortext04text.color.b, 0f);
        narratortext04go.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        LeanTween.alpha(narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
        narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);

        if (PlayerPrefs.GetString("drowning") == "The twins drowned") {
            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...the twins drowned..."];
            Image narratortext05image = narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext05image.color = new Color(narratortext05image.color.r, narratortext05image.color.g, narratortext05image.color.b, 0f);
            TMP_Text narratortext05text = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext05text.color = new Color(narratortext05text.color.r, narratortext05text.color.g, narratortext05text.color.b, 0f);
            narratortext05go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage03go = Instantiate(narratorWithImage) as GameObject;
            narratorimage03go.SetActive(false);
            narratorimage03go.transform.parent = gameObject.transform;
            Transform narratorimage03 = narratorimage03go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage03.GetComponent<Image>().preserveAspect = true;
            narratorimage03.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-7-1");
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage03go.SetActive(true);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

            GameObject narratorimage04go = Instantiate(narratorWithImage) as GameObject;
            narratorimage04go.SetActive(false);
            narratorimage04go.transform.parent = gameObject.transform;
            Transform narratorimage04 = narratorimage04go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage04.GetComponent<Image>().preserveAspect = true;
            narratorimage04.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-7-2");
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage04go.SetActive(true);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

            GameObject narratortext06go = Instantiate(narrator) as GameObject;
            narratortext06go.SetActive(false);
            narratortext06go.transform.parent = gameObject.transform;
            Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...but you are safe."];
            Image narratortext06image = narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext06image.color = new Color(narratortext06image.color.r, narratortext06image.color.g, narratortext06image.color.b, 0f);
            TMP_Text narratortext06text = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext06text.color = new Color(narratortext06text.color.r, narratortext06text.color.g, narratortext06text.color.b, 0f);
            narratortext06go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage05go = Instantiate(narratorWithImage) as GameObject;
            narratorimage05go.SetActive(false);
            narratorimage05go.transform.parent = gameObject.transform;
            Transform narratorimage05 = narratorimage05go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage05.GetComponent<Image>().preserveAspect = true;
            narratorimage05.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-9");
            LeanTween.alpha(narratorimage05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage05go.SetActive(true);
            LeanTween.alpha(narratorimage05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage05go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("drowning") == "Tommy drowned") {
            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...Tommy drowned..."];
            Image narratortext05image = narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext05image.color = new Color(narratortext05image.color.r, narratortext05image.color.g, narratortext05image.color.b, 0f);
            TMP_Text narratortext05text = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext05text.color = new Color(narratortext05text.color.r, narratortext05text.color.g, narratortext05text.color.b, 0f);
            narratortext05go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage03go = Instantiate(narratorWithImage) as GameObject;
            narratorimage03go.SetActive(false);
            narratorimage03go.transform.parent = gameObject.transform;
            Transform narratorimage03 = narratorimage03go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage03.GetComponent<Image>().preserveAspect = true;
            narratorimage03.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-7-2");
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage03go.SetActive(true);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

            GameObject narratortext06go = Instantiate(narrator) as GameObject;
            narratortext06go.SetActive(false);
            narratortext06go.transform.parent = gameObject.transform;
            Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...but you saved Nicholas."];
            Image narratortext06image = narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext06image.color = new Color(narratortext06image.color.r, narratortext06image.color.g, narratortext06image.color.b, 0f);
            TMP_Text narratortext06text = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext06text.color = new Color(narratortext06text.color.r, narratortext06text.color.g, narratortext06text.color.b, 0f);
            narratortext06go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage04go = Instantiate(narratorWithImage) as GameObject;
            narratorimage04go.SetActive(false);
            narratorimage04go.transform.parent = gameObject.transform;
            Transform narratorimage04 = narratorimage04go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage04.GetComponent<Image>().preserveAspect = true;
            narratorimage04.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-8-1");
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage04go.SetActive(true);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("drowning") == "Nicholas drowned") {
            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...Nicholas drowned..."];
            Image narratortext05image = narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext05image.color = new Color(narratortext05image.color.r, narratortext05image.color.g, narratortext05image.color.b, 0f);
            TMP_Text narratortext05text = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext05text.color = new Color(narratortext05text.color.r, narratortext05text.color.g, narratortext05text.color.b, 0f);
            narratortext05go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage03go = Instantiate(narratorWithImage) as GameObject;
            narratorimage03go.SetActive(false);
            narratorimage03go.transform.parent = gameObject.transform;
            Transform narratorimage03 = narratorimage03go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage03.GetComponent<Image>().preserveAspect = true;
            narratorimage03.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-7-1");
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage03go.SetActive(true);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

            GameObject narratortext06go = Instantiate(narrator) as GameObject;
            narratortext06go.SetActive(false);
            narratortext06go.transform.parent = gameObject.transform;
            Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...but you saved Tommy."];
            Image narratortext06image = narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext06image.color = new Color(narratortext06image.color.r, narratortext06image.color.g, narratortext06image.color.b, 0f);
            TMP_Text narratortext06text = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext06text.color = new Color(narratortext06text.color.r, narratortext06text.color.g, narratortext06text.color.b, 0f);
            narratortext06go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage04go = Instantiate(narratorWithImage) as GameObject;
            narratorimage04go.SetActive(false);
            narratorimage04go.transform.parent = gameObject.transform;
            Transform narratorimage04 = narratorimage04go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage04.GetComponent<Image>().preserveAspect = true;
            narratorimage04.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap3-8-2");
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage04go.SetActive(true);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }
    }
}