using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NotePainter5 : MonoBehaviour
{
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        highlightsTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["You were staring at the lake when Grandma came to you..."] = "You were staring at the lake when Grandma came to you...",
                ["...you and Grandma travelled through time..."] = "...you and Grandma travelled through time...",
                ["...to the day you were born."] = "...to the day you were born.",
                ["...you tried to open the door."] = "...you tried to open the door.",
                ["...you didn't want to open the door."] = "...you didn't want to open the door.",
                ["...Grandma explained time travel to you."] = "...Grandma explained time travel to you.",
                ["You were staring at the lake when Grandpa came to you..."] = "You were staring at the lake when Grandpa came to you...",
                ["...you told Grandpa you felt guilty."] = "...you told Grandpa you felt guilty.",
                ["...you accidentally travelled through time..."] = "...you accidentally travelled through time...",
                ["...and you ended up at your grandparents' place in the 70s."] = "...and you ended up at your grandparents' place in the 70s.",
                ["...Grandma found you."] = "...Grandma found you.",
                ["...you took the toy car."] = "...you took the toy car.",
                ["...you didn't take the toy car."] = "...you didn't take the toy car."
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["You were staring at the lake when Grandma came to you..."] = "Stavi osservando il lago quando la nonna si è avvicinata a te...",
                ["...you and Grandma travelled through time..."] = "...tu e la nonna avete viaggiato nel tempo...",
                ["...to the day you were born."] = "...al giorno in cui sei nata.",
                ["...you tried to open the door."] = "...hai provato ad aprire la porta.",
                ["...you didn't want to open the door."] = "...non hai voluto aprire la porta.",
                ["...Grandma explained time travel to you."] = "...la nonna ti ha spiegato il viaggio nel tempo.",
                ["You were staring at the lake when Grandpa came to you..."] = "Stavi osservando il lago quando il nonno si è avvicinato a te...",
                ["...you told Grandpa you felt guilty."] = "...hai detto al nonno che ti senti in colpa.",
                ["...you accidentally travelled through time..."] = "...hai accidentalmente viaggiato nel tempo...",
                ["...and you ended up at your grandparents' place in the 70s."] = "...e sei finita nel posto dei tuoi nonni negli anni 70.",
                ["...Grandma found you."] = "...la nonna ti ha trovato.",
                ["...you took the toy car."] = "...hai preso la macchina giocattolo.",
                ["...you didn't take the toy car."] = "...non hai preso la macchina giocattolo."
            }
        };
        GameObject.Find("Ending title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        if (PlayerPrefs.GetInt("grandma_dead") == 0) {
            GameObject narratortextgo = Instantiate(narrator) as GameObject;
            narratortextgo.SetActive(false);
            narratortextgo.transform.parent = gameObject.transform;
            Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["You were staring at the lake when Grandma came to you..."];
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
            narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap4-1-nonna");
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimagego.SetActive(true);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you and Grandma travelled through time..."];
            Image narratortext02image = narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext02image.color = new Color(narratortext02image.color.r, narratortext02image.color.g, narratortext02image.color.b, 0f);
            TMP_Text narratortext02text = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext02text.color = new Color(narratortext02text.color.r, narratortext02text.color.g, narratortext02text.color.b, 0f);
            narratortext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage02go = Instantiate(narratorWithImage) as GameObject;
            narratorimage02go.SetActive(false);
            narratorimage02go.transform.parent = gameObject.transform;
            Transform narratorimage02 = narratorimage02go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage02.GetComponent<Image>().preserveAspect = true;
            narratorimage02.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap4-7-nonna");
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage02go.SetActive(true);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

            GameObject narratortext03go = Instantiate(narrator) as GameObject;
            narratortext03go.SetActive(false);
            narratortext03go.transform.parent = gameObject.transform;
            Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...to the day you were born."];
            Image narratortext03image = narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext03image.color = new Color(narratortext03image.color.r, narratortext03image.color.g, narratortext03image.color.b, 0f);
            TMP_Text narratortext03text = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext03text.color = new Color(narratortext03text.color.r, narratortext03text.color.g, narratortext03text.color.b, 0f);
            narratortext03go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage03go = Instantiate(narratorWithImage) as GameObject;
            narratorimage03go.SetActive(false);
            narratorimage03go.transform.parent = gameObject.transform;
            Transform narratorimage03 = narratorimage03go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage03.GetComponent<Image>().preserveAspect = true;
            narratorimage03.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap4-2");
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage03go.SetActive(true);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

            if (PlayerPrefs.GetString("door") == "You tried to open the door") {
                GameObject narratortext04go = Instantiate(narrator) as GameObject;
                narratortext04go.SetActive(false);
                narratortext04go.transform.parent = gameObject.transform;
                Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
                narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you tried to open the door."];
                Image narratortext04image = narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
                narratortext04image.color = new Color(narratortext04image.color.r, narratortext04image.color.g, narratortext04image.color.b, 0f);
                TMP_Text narratortext04text = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
                narratortext04text.color = new Color(narratortext04text.color.r, narratortext04text.color.g, narratortext04text.color.b, 0f);
                narratortext04go.SetActive(true);
                yield return new WaitForSeconds(0.001f);
                LeanTween.alpha(narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
                narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
                yield return new WaitForSeconds(0.4f);

                GameObject narratorimage04go = Instantiate(narratorWithImage) as GameObject;
                narratorimage04go.SetActive(false);
                narratorimage04go.transform.parent = gameObject.transform;
                Transform narratorimage04 = narratorimage04go.transform.Find("Textbox container/Narrator text/Image");
                narratorimage04.GetComponent<Image>().preserveAspect = true;
                narratorimage04.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap4-4");
                LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
                narratorimage04go.SetActive(true);
                LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
                LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
                yield return new WaitForSeconds(0.6f);
            } else if (PlayerPrefs.GetString("door") == "You didn't want to open the door") {
                GameObject narratortext04go = Instantiate(narrator) as GameObject;
                narratortext04go.SetActive(false);
                narratortext04go.transform.parent = gameObject.transform;
                Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
                narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you didn't want to open the door."];
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

            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...Grandma explained time travel to you."];
            Image narratortext05image = narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext05image.color = new Color(narratortext05image.color.r, narratortext05image.color.g, narratortext05image.color.b, 0f);
            TMP_Text narratortext05text = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext05text.color = new Color(narratortext05text.color.r, narratortext05text.color.g, narratortext05text.color.b, 0f);
            narratortext05go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

        } else {
            GameObject narratortextgo = Instantiate(narrator) as GameObject;
            narratortextgo.SetActive(false);
            narratortextgo.transform.parent = gameObject.transform;
            Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["You were staring at the lake when Grandpa came to you..."];
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
            narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap4-1-nonno");
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimagego.SetActive(true);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

            if (PlayerPrefs.GetString("guilty") == "You told Grandpa you felt guilty") {
                GameObject narratortext02go = Instantiate(narrator) as GameObject;
                narratortext02go.SetActive(false);
                narratortext02go.transform.parent = gameObject.transform;
                Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
                narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you told Grandpa you felt guilty."];
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

            GameObject narratortext03go = Instantiate(narrator) as GameObject;
            narratortext03go.SetActive(false);
            narratortext03go.transform.parent = gameObject.transform;
            Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you accidentally travelled through time..."];
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
            narratorimage02.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap4-7");
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage02go.SetActive(true);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

            GameObject narratortext04go = Instantiate(narrator) as GameObject;
            narratortext04go.SetActive(false);
            narratortext04go.transform.parent = gameObject.transform;
            Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...and you ended up at your grandparents' place in the 70s."];
            Image narratortext04image = narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext04image.color = new Color(narratortext04image.color.r, narratortext04image.color.g, narratortext04image.color.b, 0f);
            TMP_Text narratortext04text = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext04text.color = new Color(narratortext04text.color.r, narratortext04text.color.g, narratortext04text.color.b, 0f);
            narratortext04go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...Grandma found you."];
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
            narratorimage03.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap4-6");
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage03go.SetActive(true);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

            if (PlayerPrefs.GetString("car") == "You took the toy car") {
                GameObject narratortext06go = Instantiate(narrator) as GameObject;
                narratortext06go.SetActive(false);
                narratortext06go.transform.parent = gameObject.transform;
                Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
                narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you took the toy car."];
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
                narratorimage04.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap4-5");
                LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
                narratorimage04go.SetActive(true);
                LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
                LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
                yield return new WaitForSeconds(0.6f);

            } else if (PlayerPrefs.GetString("car") == "You didn't take the toy car") {
                GameObject narratortext06go = Instantiate(narrator) as GameObject;
                narratortext06go.SetActive(false);
                narratortext06go.transform.parent = gameObject.transform;
                Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
                narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you didn't take the toy car."];
                Image narratortext06image = narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
                narratortext06image.color = new Color(narratortext06image.color.r, narratortext06image.color.g, narratortext06image.color.b, 0f);
                TMP_Text narratortext06text = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
                narratortext06text.color = new Color(narratortext06text.color.r, narratortext06text.color.g, narratortext06text.color.b, 0f);
                narratortext06go.SetActive(true);
                yield return new WaitForSeconds(0.001f);
                LeanTween.alpha(narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
                narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
                yield return new WaitForSeconds(0.4f);
            }

            GameObject narratortext07go = Instantiate(narrator) as GameObject;
            narratortext07go.SetActive(false);
            narratortext07go.transform.parent = gameObject.transform;
            Transform narratortext07 = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext07.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...Grandma explained time travel to you."];
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
    }
}