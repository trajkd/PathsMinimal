using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NotePainter3 : MonoBehaviour
{
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        highlightsTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["On your arrival at the grandparents' house..."] = "On your arrival at the grandparents' house...",
                ["On your arrival at Grandpa's house..."] = "On your arrival at Grandpa's house...",
                ["...you asked Grandpa how he was."] = "...you asked Grandpa how he was.",
                ["...you hugged Grandpa."] = "...you hugged Grandpa.",
                ["...you asked Grandpa where Grandma was."] = "...you asked Grandpa where Grandma was.",
                ["...you guessed that grandpa’s project was a vegetable garden."] = "...you guessed that grandpa’s project was a vegetable garden.",
                ["...you chose to speak with Grandma."] = "...you chose to speak with Grandma.",
                ["...you chose to speak with Grandpa before Grandma."] = "...you chose to speak with Grandpa before Grandma.",
                ["...you thought Grandma’s habit was weird."] = "...you thought Grandma’s habit was weird.",
                ["...you thought Grandma’s habit was cool."] = "...you thought Grandma’s habit was cool.",
                ["...you went to the darkroom alone."] = "...you went to the darkroom alone.",
                ["...you went to the darkroom with Grandpa."] = "...you went to the darkroom with Grandpa.",
                ["...you entered in Grandma’s darkroom without knocking."] = "...you entered in Grandma’s darkroom without knocking.",
                ["...you didn’t listen to Grandpa in the darkroom."] = "...you didn’t listen to Grandpa in the darkroom.",
                ["...you did what Grandpa asked you to do in the darkroom."] = "...you did what Grandpa asked you to do in the darkroom.",
                ["...you saw a mysterious chest."] = "...you saw a mysterious chest."
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["On your arrival at the grandparents' house..."] = "Al tuo arrivo alla casa dei nonni...",
                ["On your arrival at Grandpa's house..."] = "Al tuo arrivo alla casa del nonno...",
                ["...you asked Grandpa how he was."] = "...hai chiesto al nonno come sta.",
                ["...you hugged Grandpa."] = "...hai abbracciato il nonno.",
                ["...you asked Grandpa where Grandma was."] = "...hai chiesto al nonno dove fosse la nonna.",
                ["...you guessed that grandpa’s project was a vegetable garden."] = "...hai indovinato che il progetto del nonno era un orto.",
                ["...you chose to speak with Grandma."] = "...hai scelto di parlare con la nonna.",
                ["...you chose to speak with Grandpa before Grandma."] = "...hai scelto di parlare con il nonno prima della nonna.",
                ["...you thought Grandma’s habit was weird."] = "...hai pensato che l'abitudine della nonna fosse strana.",
                ["...you thought Grandma’s habit was cool."] = "...hai pensato che l'abitudine della nonna fosse forte.",
                ["...you went to the darkroom alone."] = "...sei andata nella camera oscura da sola.",
                ["...you went to the darkroom with Grandpa."] = "...sei andata nella camera oscura con il nonno.",
                ["...you entered in Grandma’s darkroom without knocking."] = "...sei entrata nella camera oscura della nonna senza bussare.",
                ["...you didn’t listen to Grandpa in the darkroom."] = "...non hai ascoltato il nonno nella camera oscura.",
                ["...you did what Grandpa asked you to do in the darkroom."] = "...hai fatto quello che il nonno ti ha chiesto di fare nella camera oscura.",
                ["...you saw a mysterious chest."] = "...hai visto una cesta misteriosa."
            }
        };
        GameObject.Find("Ending title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        GameObject narratortextgo = Instantiate(narrator) as GameObject;
        narratortextgo.SetActive(false);
        narratortextgo.transform.parent = gameObject.transform;
        Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        if (PlayerPrefs.GetInt("grandma_dead") == 0) {
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["On your arrival at the grandparents' house..."];
        } else {
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["On your arrival at Grandpa's house..."];
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
        
        if (PlayerPrefs.GetString("grandma_dead_action") == "You asked Grandpa how he was") {
            GameObject narratortext01go = Instantiate(narrator) as GameObject;
            narratortext01go.SetActive(false);
            narratortext01go.transform.parent = gameObject.transform;
            Transform narratortext01 = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext01.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you asked Grandpa how he was."];
            Image narratortext01image = narratortext01go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext01image.color = new Color(narratortext01image.color.r, narratortext01image.color.g, narratortext01image.color.b, 0f);
            TMP_Text narratortext01text = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext01text.color = new Color(narratortext01text.color.r, narratortext01text.color.g, narratortext01text.color.b, 0f);
            narratortext01go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext01go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("grandma_dead_action") == "You hugged Grandpa") {
            GameObject narratortext01go = Instantiate(narrator) as GameObject;
            narratortext01go.SetActive(false);
            narratortext01go.transform.parent = gameObject.transform;
            Transform narratortext01 = narratortext01go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext01.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you hugged Grandpa."];
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

        if (PlayerPrefs.GetString("grandma_alive_action") == "You asked Grandpa how he was") {
            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you asked Grandpa how he was."];
            Image narratortext02image = narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext02image.color = new Color(narratortext02image.color.r, narratortext02image.color.g, narratortext02image.color.b, 0f);
            TMP_Text narratortext02text = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext02text.color = new Color(narratortext02text.color.r, narratortext02text.color.g, narratortext02text.color.b, 0f);
            narratortext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("grandma_alive_action") == "You asked Grandpa where Grandma was") {
            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you asked Grandpa where Grandma was."];
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

        if (PlayerPrefs.GetString("green_thumb") == "You guessed that grandpa’s project was a vegetable garden") {
            GameObject narratortext03go = Instantiate(narrator) as GameObject;
            narratortext03go.SetActive(false);
            narratortext03go.transform.parent = gameObject.transform;
            Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you guessed that grandpa’s project was a vegetable garden."];
            Image narratortext03image = narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext03image.color = new Color(narratortext03image.color.r, narratortext03image.color.g, narratortext03image.color.b, 0f);
            TMP_Text narratortext03text = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext03text.color = new Color(narratortext03text.color.r, narratortext03text.color.g, narratortext03text.color.b, 0f);
            narratortext03go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage01go = Instantiate(narratorWithImage) as GameObject;
            narratorimage01go.SetActive(false);
            narratorimage01go.transform.parent = gameObject.transform;
            Transform narratorimage01 = narratorimage01go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage01.GetComponent<Image>().preserveAspect = true;
            narratorimage01.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap2-1");
            LeanTween.alpha(narratorimage01go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage01go.SetActive(true);
            LeanTween.alpha(narratorimage01go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage01go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        if (PlayerPrefs.GetString("first_speech") == "You chose to speak with Grandma") {
            GameObject narratortext04go = Instantiate(narrator) as GameObject;
            narratortext04go.SetActive(false);
            narratortext04go.transform.parent = gameObject.transform;
            Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you chose to speak with Grandma."];
            Image narratortext04image = narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext04image.color = new Color(narratortext04image.color.r, narratortext04image.color.g, narratortext04image.color.b, 0f);
            TMP_Text narratortext04text = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext04text.color = new Color(narratortext04text.color.r, narratortext04text.color.g, narratortext04text.color.b, 0f);
            narratortext04go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("first_speech") == "You chose to speak with Grandpa before Grandma") {
            GameObject narratortext04go = Instantiate(narrator) as GameObject;
            narratortext04go.SetActive(false);
            narratortext04go.transform.parent = gameObject.transform;
            Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you chose to speak with Grandpa before Grandma."];
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

        if (PlayerPrefs.GetString("grandmas_habit") == "You thought Grandma’s habit was weird") {
            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you thought Grandma’s habit was weird."];
            Image narratortext05image = narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext05image.color = new Color(narratortext05image.color.r, narratortext05image.color.g, narratortext05image.color.b, 0f);
            TMP_Text narratortext05text = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext05text.color = new Color(narratortext05text.color.r, narratortext05text.color.g, narratortext05text.color.b, 0f);
            narratortext05go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("grandmas_habit") == "You thought Grandma’s habit was cool") {
            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you thought Grandma’s habit was cool."];
            Image narratortext05image = narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext05image.color = new Color(narratortext05image.color.r, narratortext05image.color.g, narratortext05image.color.b, 0f);
            TMP_Text narratortext05text = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext05text.color = new Color(narratortext05text.color.r, narratortext05text.color.g, narratortext05text.color.b, 0f);
            narratortext05go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        if (PlayerPrefs.GetString("darkroom") == "You went to the darkroom alone") {
            GameObject narratortext06go = Instantiate(narrator) as GameObject;
            narratortext06go.SetActive(false);
            narratortext06go.transform.parent = gameObject.transform;
            Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you went to the darkroom alone."];
            Image narratortext06image = narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext06image.color = new Color(narratortext06image.color.r, narratortext06image.color.g, narratortext06image.color.b, 0f);
            TMP_Text narratortext06text = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext06text.color = new Color(narratortext06text.color.r, narratortext06text.color.g, narratortext06text.color.b, 0f);
            narratortext06go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage02go = Instantiate(narratorWithImage) as GameObject;
            narratorimage02go.SetActive(false);
            narratorimage02go.transform.parent = gameObject.transform;
            Transform narratorimage02 = narratorimage02go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage02.GetComponent<Image>().preserveAspect = true;
            narratorimage02.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap2-2-1");
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage02go.SetActive(true);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("darkroom") == "You went to the darkroom with Grandpa") {
            GameObject narratortext06go = Instantiate(narrator) as GameObject;
            narratortext06go.SetActive(false);
            narratortext06go.transform.parent = gameObject.transform;
            Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you went to the darkroom with Grandpa."];
            Image narratortext06image = narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext06image.color = new Color(narratortext06image.color.r, narratortext06image.color.g, narratortext06image.color.b, 0f);
            TMP_Text narratortext06text = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext06text.color = new Color(narratortext06text.color.r, narratortext06text.color.g, narratortext06text.color.b, 0f);
            narratortext06go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage02go = Instantiate(narratorWithImage) as GameObject;
            narratorimage02go.SetActive(false);
            narratorimage02go.transform.parent = gameObject.transform;
            Transform narratorimage02 = narratorimage02go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage02.GetComponent<Image>().preserveAspect = true;
            narratorimage02.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap2-2-2");
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage02go.SetActive(true);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        if (PlayerPrefs.GetString("without_knocking") == "You entered in Grandma’s darkroom without knocking") {
            GameObject narratortext07go = Instantiate(narrator) as GameObject;
            narratortext07go.SetActive(false);
            narratortext07go.transform.parent = gameObject.transform;
            Transform narratortext07 = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext07.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you entered in Grandma’s darkroom without knocking."];
            Image narratortext07image = narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext07image.color = new Color(narratortext07image.color.r, narratortext07image.color.g, narratortext07image.color.b, 0f);
            TMP_Text narratortext07text = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext07text.color = new Color(narratortext07text.color.r, narratortext07text.color.g, narratortext07text.color.b, 0f);
            narratortext07go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }
        
        if (PlayerPrefs.GetString("listen_to_grandpa") == "You didn’t listen to Grandpa in the darkroom") {
            GameObject narratortext08go = Instantiate(narrator) as GameObject;
            narratortext08go.SetActive(false);
            narratortext08go.transform.parent = gameObject.transform;
            Transform narratortext08 = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext08.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you didn’t listen to Grandpa in the darkroom."];
            Image narratortext08image = narratortext08go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext08image.color = new Color(narratortext08image.color.r, narratortext08image.color.g, narratortext08image.color.b, 0f);
            TMP_Text narratortext08text = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext08text.color = new Color(narratortext08text.color.r, narratortext08text.color.g, narratortext08text.color.b, 0f);
            narratortext08go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("listen_to_grandpa") == "You did what Grandpa asked you to do in the darkroom") {
            GameObject narratortext08go = Instantiate(narrator) as GameObject;
            narratortext08go.SetActive(false);
            narratortext08go.transform.parent = gameObject.transform;
            Transform narratortext08 = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext08.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you did what Grandpa asked you to do in the darkroom."];
            Image narratortext08image = narratortext08go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext08image.color = new Color(narratortext08image.color.r, narratortext08image.color.g, narratortext08image.color.b, 0f);
            TMP_Text narratortext08text = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext08text.color = new Color(narratortext08text.color.r, narratortext08text.color.g, narratortext08text.color.b, 0f);
            narratortext08go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        if (PlayerPrefs.GetString("chest") == "You saw a mysterious chest") {
            GameObject narratortext09go = Instantiate(narrator) as GameObject;
            narratortext09go.SetActive(false);
            narratortext09go.transform.parent = gameObject.transform;
            Transform narratortext09 = narratortext09go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext09.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you saw a mysterious chest."];
            Image narratortext09image = narratortext09go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext09image.color = new Color(narratortext09image.color.r, narratortext09image.color.g, narratortext09image.color.b, 0f);
            TMP_Text narratortext09text = narratortext09go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext09text.color = new Color(narratortext09text.color.r, narratortext09text.color.g, narratortext09text.color.b, 0f);
            narratortext09go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext09go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext09go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage03go = Instantiate(narratorWithImage) as GameObject;
            narratorimage03go.SetActive(false);
            narratorimage03go.transform.parent = gameObject.transform;
            Transform narratorimage03 = narratorimage03go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage03.GetComponent<Image>().preserveAspect = true;
            if (PlayerPrefs.GetInt("grandma_dead") == 0) {
                narratorimage03.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap2-3");
            } else {
                narratorimage03.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap2-3-2");
            }
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage03go.SetActive(true);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }
    }
}