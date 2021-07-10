using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Ending8Painter : MonoBehaviour
{
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    [SerializeField]GameObject continueButton;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        SceneManager.UnloadScene("Chapter8");
        highlightsTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["You prepared everything for the travels..."] = "You prepared everything for the travels...",
                ["...you left a gift for your past self."] = "...you left a gift for your past self.",
                ["...you left a gift and a note for your past self."] = "...you left a gift and a note for your past self.",
                ["...you got caught by dad and you had to run away."] = "...you got caught by dad and you had to run away.",
                ["...you left a note for your past self."] = "...you left a note for your past self.",
                ["...you got caught by Grandpa and you had to run away."] = "...you got caught by Grandpa and you had to run away.",
                ["...you brought a gift to your brothers."] = "...you brought a gift to your brothers.",
                ["...you didn't have a gift for your brothers."] = "...you didn't have a gift for your brothers.",
                ["...you had a lovely afternoon."] = "...you had a lovely afternoon.",
                ["...you argued with your family and left the house."] = "...you argued with your family and left the house.",
                ["...you pretended to be mom."] = "...you pretended to be mom.",
                ["...you pretended to be a college recruiter."] = "...you pretended to be a college recruiter.",
                ["...you asked for Grandma's help to defend Tommy and Nic."] = "...you asked for Grandma's help to defend Tommy and Nic.",
                ["...you managed to defend your brothers."] = "...you managed to defend your brothers.",
                ["...you didn't defend your brothers."] = "...you didn't defend your brothers.",
                ["...you watched your past self as she defended your Tommy and Nic."] = "...you watched your past self as she defended Tommy and Nic.",
                ["...you watched your past self as she didn't defend your Tommy and Nic."] = "...you watched your past self as she didn't defend Tommy and Nic.",
                ["...you broke time."] = "...you broke time."
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["You prepared everything for the travels..."] = "Hai preparato tutto per i viaggi...",
                ["...you left a gift for your past self."] = "...hai lasciato un regalo per te stessa del passato.",
                ["...you left a gift and a note for your past self."] = "...hai lasciato un regalo e una nota per te stessa del passato.",
                ["...you got caught by dad and you had to run away."] = "...papà ti ha scovato e sei dovuta scappare via.",
                ["...you left a note for your past self."] = "...hai lasciato una nota per te stessa del passato.",
                ["...you got caught by Grandpa and you had to run away."] = "...il nonno ti ha scovato e sei dovuta scappare via.",
                ["...you brought a gift to your brothers."] = "...hai portato un regalo ai tuoi fratelli.",
                ["...you didn't have a gift for your brothers."] = "...non avevi un regalo per i tuoi fratelli.",
                ["...you had a lovely afternoon."] = "...hai passato un pomeriggio piacevole.",
                ["...you argued with your family and left the house."] = "...hai litigato con la tua famiglia e hai abbandonato casa.",
                ["...you pretended to be mom."] = "...hai fatto finta di essere la mamma.",
                ["...you pretended to be a college recruiter."] = "...hai fatto finta di essere un reclutatore universitario.",
                ["...you asked for Grandma's help to defend Tommy and Nic."] = "...hai chiesto aiuto alla nonna per difendere Tommy e Nic.",
                ["...you managed to defend your brothers."] = "...sei riuscita a difendere i tuoi fratelli.",
                ["...you didn't defend your brothers."] = "...non hai difeso i tuoi fratelli.",
                ["...you watched your past self as she defended your Tommy and Nic."] = "...hai guardato come te stessa del passato ha difeso Tommy e Nic.",
                ["...you watched your past self as she didn't defend your Tommy and Nic."] = "...hai guardato come te stessa del passato non ha difeso Tommy e Nic.",
                ["...you broke time."] = "...hai rotto il tempo."
            }
        };
        GameObject.Find("Ending title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        GameObject narratortextgo = Instantiate(narrator) as GameObject;
        narratortextgo.SetActive(false);
        narratortextgo.transform.parent = gameObject.transform;
        Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["You prepared everything for the travels..."];
        Image narratortextimage = narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
        narratortextimage.color = new Color(narratortextimage.color.r, narratortextimage.color.g, narratortextimage.color.b, 0f);
        TMP_Text narratortexttext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
        narratortexttext.color = new Color(narratortexttext.color.r, narratortexttext.color.g, narratortexttext.color.b, 0f);
        narratortextgo.SetActive(true);
        yield return new WaitForSeconds(0.001f);
        LeanTween.alpha(narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
        narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);

        if (PlayerPrefs.GetString("memory") == "You chose the twins' birth memory") {
            GameObject narratorimagego = Instantiate(narratorWithImage) as GameObject;
            narratorimagego.SetActive(false);
            narratorimagego.transform.parent = gameObject.transform;
            Transform narratorimage = narratorimagego.transform.Find("Textbox container/Narrator text/Image");
            narratorimage.GetComponent<Image>().preserveAspect = true;
            narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-1-1");
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimagego.SetActive(true);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("memory") == "You chose the Christmas memory") {
            GameObject narratorimagego = Instantiate(narratorWithImage) as GameObject;
            narratorimagego.SetActive(false);
            narratorimagego.transform.parent = gameObject.transform;
            Transform narratorimage = narratorimagego.transform.Find("Textbox container/Narrator text/Image");
            narratorimage.GetComponent<Image>().preserveAspect = true;
            narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-1-2");
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimagego.SetActive(true);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        if (PlayerPrefs.GetString("christmas_memory_action") == "You left a gift for your past self") {
            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you left a gift for your past self."];
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
            narratorimage02.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-3-2");
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage02go.SetActive(true);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

        } else if (PlayerPrefs.GetString("christmas_memory_action") == "You left a gift and a note for your past self") {
            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you left a gift and a note for your past self."];
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
            narratorimage02.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-3");
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage02go.SetActive(true);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

        } else if (PlayerPrefs.GetString("christmas_memory_action") == "You got caught by dad and you had to run away") {
            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you got caught by dad and you had to run away."];
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

        if (PlayerPrefs.GetString("birth_memory_action") == "You left a note for your past self") {
            GameObject narratortext03go = Instantiate(narrator) as GameObject;
            narratortext03go.SetActive(false);
            narratortext03go.transform.parent = gameObject.transform;
            Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you left a note for your past self."];
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
            narratorimage03.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-3-3");
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage03go.SetActive(true);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

        } else if (PlayerPrefs.GetString("birth_memory_action") == "You got caught by Grandpa and you had to run away") {
            GameObject narratortext03go = Instantiate(narrator) as GameObject;
            narratortext03go.SetActive(false);
            narratortext03go.transform.parent = gameObject.transform;
            Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you got caught by Grandpa and you had to run away."];
            Image narratortext03image = narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext03image.color = new Color(narratortext03image.color.r, narratortext03image.color.g, narratortext03image.color.b, 0f);
            TMP_Text narratortext03text = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext03text.color = new Color(narratortext03text.color.r, narratortext03text.color.g, narratortext03text.color.b, 0f);
            narratortext03go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        if (PlayerPrefs.GetString("caught_image") == "7-2-2") {
            GameObject narratorimage04go = Instantiate(narratorWithImage) as GameObject;
            narratorimage04go.SetActive(false);
            narratorimage04go.transform.parent = gameObject.transform;
            Transform narratorimage04 = narratorimage04go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage04.GetComponent<Image>().preserveAspect = true;
            narratorimage04.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-2-2");
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage04go.SetActive(true);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

        } else if (PlayerPrefs.GetString("caught_image") == "7-2-1") {
            GameObject narratorimage04go = Instantiate(narratorWithImage) as GameObject;
            narratorimage04go.SetActive(false);
            narratorimage04go.transform.parent = gameObject.transform;
            Transform narratorimage04 = narratorimage04go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage04.GetComponent<Image>().preserveAspect = true;
            narratorimage04.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-2-1");
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage04go.SetActive(true);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);

        }
        
        if (PlayerPrefs.GetString("gift_to_brothers") == "You brought a gift to your brothers") {
            GameObject narratortext04go = Instantiate(narrator) as GameObject;
            narratortext04go.SetActive(false);
            narratortext04go.transform.parent = gameObject.transform;
            Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you brought a gift to your brothers."];
            Image narratortext04image = narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext04image.color = new Color(narratortext04image.color.r, narratortext04image.color.g, narratortext04image.color.b, 0f);
            TMP_Text narratortext04text = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext04text.color = new Color(narratortext04text.color.r, narratortext04text.color.g, narratortext04text.color.b, 0f);
            narratortext04go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage05go = Instantiate(narratorWithImage) as GameObject;
            narratorimage05go.SetActive(false);
            narratorimage05go.transform.parent = gameObject.transform;
            Transform narratorimage05 = narratorimage05go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage05.GetComponent<Image>().preserveAspect = true;
            narratorimage05.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-4");
            LeanTween.alpha(narratorimage05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage05go.SetActive(true);
            LeanTween.alpha(narratorimage05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage05go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("gift_to_brothers") == "You didn't have a gift for your brothers") {
            GameObject narratortext04go = Instantiate(narrator) as GameObject;
            narratortext04go.SetActive(false);
            narratortext04go.transform.parent = gameObject.transform;
            Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you didn't have a gift for your brothers."];
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

        if (PlayerPrefs.GetString("afternoon") == "You had a lovely afternoon") {
            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you had a lovely afternoon."];
            Image narratortext05image = narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext05image.color = new Color(narratortext05image.color.r, narratortext05image.color.g, narratortext05image.color.b, 0f);
            TMP_Text narratortext05text = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext05text.color = new Color(narratortext05text.color.r, narratortext05text.color.g, narratortext05text.color.b, 0f);
            narratortext05go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage06go = Instantiate(narratorWithImage) as GameObject;
            narratorimage06go.SetActive(false);
            narratorimage06go.transform.parent = gameObject.transform;
            Transform narratorimage06 = narratorimage06go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage06.GetComponent<Image>().preserveAspect = true;
            narratorimage06.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-5");
            LeanTween.alpha(narratorimage06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage06go.SetActive(true);
            LeanTween.alpha(narratorimage06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage06go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("afternoon") == "You argued with your family and left the house") {
            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you argued with your family and left the house."];
            Image narratortext05image = narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext05image.color = new Color(narratortext05image.color.r, narratortext05image.color.g, narratortext05image.color.b, 0f);
            TMP_Text narratortext05text = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext05text.color = new Color(narratortext05text.color.r, narratortext05text.color.g, narratortext05text.color.b, 0f);
            narratortext05go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage06go = Instantiate(narratorWithImage) as GameObject;
            narratorimage06go.SetActive(false);
            narratorimage06go.transform.parent = gameObject.transform;
            Transform narratorimage06 = narratorimage06go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage06.GetComponent<Image>().preserveAspect = true;
            narratorimage06.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-6");
            LeanTween.alpha(narratorimage06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage06go.SetActive(true);
            LeanTween.alpha(narratorimage06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage06go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        if (PlayerPrefs.GetString("dressed_as") == "You pretended to be mom") {
            GameObject narratortext06go = Instantiate(narrator) as GameObject;
            narratortext06go.SetActive(false);
            narratortext06go.transform.parent = gameObject.transform;
            Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you pretended to be mom."];
            Image narratortext06image = narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext06image.color = new Color(narratortext06image.color.r, narratortext06image.color.g, narratortext06image.color.b, 0f);
            TMP_Text narratortext06text = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext06text.color = new Color(narratortext06text.color.r, narratortext06text.color.g, narratortext06text.color.b, 0f);
            narratortext06go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage07go = Instantiate(narratorWithImage) as GameObject;
            narratorimage07go.SetActive(false);
            narratorimage07go.transform.parent = gameObject.transform;
            Transform narratorimage07 = narratorimage07go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage07.GetComponent<Image>().preserveAspect = true;
            narratorimage07.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-7");
            LeanTween.alpha(narratorimage07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage07go.SetActive(true);
            LeanTween.alpha(narratorimage07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage07go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("dressed_as") == "You pretended to be a college recruiter") {
            GameObject narratortext06go = Instantiate(narrator) as GameObject;
            narratortext06go.SetActive(false);
            narratortext06go.transform.parent = gameObject.transform;
            Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you pretended to be a college recruiter."];
            Image narratortext06image = narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext06image.color = new Color(narratortext06image.color.r, narratortext06image.color.g, narratortext06image.color.b, 0f);
            TMP_Text narratortext06text = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext06text.color = new Color(narratortext06text.color.r, narratortext06text.color.g, narratortext06text.color.b, 0f);
            narratortext06go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage07go = Instantiate(narratorWithImage) as GameObject;
            narratorimage07go.SetActive(false);
            narratorimage07go.transform.parent = gameObject.transform;
            Transform narratorimage07 = narratorimage07go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage07.GetComponent<Image>().preserveAspect = true;
            narratorimage07.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-7");
            LeanTween.alpha(narratorimage07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage07go.SetActive(true);
            LeanTween.alpha(narratorimage07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage07go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("dressed_as") == "You asked for Grandma's help to defend Tommy and Nic") {
            GameObject narratortext06go = Instantiate(narrator) as GameObject;
            narratortext06go.SetActive(false);
            narratortext06go.transform.parent = gameObject.transform;
            Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you asked for Grandma's help to defend Tommy and Nic."];
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

        if (PlayerPrefs.GetString("defend") == "You managed to defend your brothers") {
            GameObject narratortext07go = Instantiate(narrator) as GameObject;
            narratortext07go.SetActive(false);
            narratortext07go.transform.parent = gameObject.transform;
            Transform narratortext07 = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext07.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you managed to defend your brothers."];
            Image narratortext07image = narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext07image.color = new Color(narratortext07image.color.r, narratortext07image.color.g, narratortext07image.color.b, 0f);
            TMP_Text narratortext07text = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext07text.color = new Color(narratortext07text.color.r, narratortext07text.color.g, narratortext07text.color.b, 0f);
            narratortext07go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage08go = Instantiate(narratorWithImage) as GameObject;
            narratorimage08go.SetActive(false);
            narratorimage08go.transform.parent = gameObject.transform;
            Transform narratorimage08 = narratorimage08go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage08.GetComponent<Image>().preserveAspect = true;
            narratorimage08.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-9");
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage08go.SetActive(true);
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("defend") == "You didn't defend your brothers") {
            GameObject narratortext07go = Instantiate(narrator) as GameObject;
            narratortext07go.SetActive(false);
            narratortext07go.transform.parent = gameObject.transform;
            Transform narratortext07 = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext07.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you didn't defend your brothers."];
            Image narratortext07image = narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext07image.color = new Color(narratortext07image.color.r, narratortext07image.color.g, narratortext07image.color.b, 0f);
            TMP_Text narratortext07text = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext07text.color = new Color(narratortext07text.color.r, narratortext07text.color.g, narratortext07text.color.b, 0f);
            narratortext07go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage08go = Instantiate(narratorWithImage) as GameObject;
            narratorimage08go.SetActive(false);
            narratorimage08go.transform.parent = gameObject.transform;
            Transform narratorimage08 = narratorimage08go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage08.GetComponent<Image>().preserveAspect = true;
            narratorimage08.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-10");
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage08go.SetActive(true);
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("defend") == "You watched your past self as she defended your Tommy and Nic") {
            GameObject narratortext07go = Instantiate(narrator) as GameObject;
            narratortext07go.SetActive(false);
            narratortext07go.transform.parent = gameObject.transform;
            Transform narratortext07 = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext07.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you watched your past self as she defended your Tommy and Nic."];
            Image narratortext07image = narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext07image.color = new Color(narratortext07image.color.r, narratortext07image.color.g, narratortext07image.color.b, 0f);
            TMP_Text narratortext07text = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext07text.color = new Color(narratortext07text.color.r, narratortext07text.color.g, narratortext07text.color.b, 0f);
            narratortext07go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage08go = Instantiate(narratorWithImage) as GameObject;
            narratorimage08go.SetActive(false);
            narratorimage08go.transform.parent = gameObject.transform;
            Transform narratorimage08 = narratorimage08go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage08.GetComponent<Image>().preserveAspect = true;
            narratorimage08.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-11");
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage08go.SetActive(true);
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("defend") == "You watched your past self as she didn't defend your Tommy and Nic") {
            GameObject narratortext07go = Instantiate(narrator) as GameObject;
            narratortext07go.SetActive(false);
            narratortext07go.transform.parent = gameObject.transform;
            Transform narratortext07 = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext07.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you watched your past self as she didn't defend your Tommy and Nic."];
            Image narratortext07image = narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext07image.color = new Color(narratortext07image.color.r, narratortext07image.color.g, narratortext07image.color.b, 0f);
            TMP_Text narratortext07text = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext07text.color = new Color(narratortext07text.color.r, narratortext07text.color.g, narratortext07text.color.b, 0f);
            narratortext07go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage08go = Instantiate(narratorWithImage) as GameObject;
            narratorimage08go.SetActive(false);
            narratorimage08go.transform.parent = gameObject.transform;
            Transform narratorimage08 = narratorimage08go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage08.GetComponent<Image>().preserveAspect = true;
            narratorimage08.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-11");
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage08go.SetActive(true);
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        if (PlayerPrefs.GetString("break_time") == "You broke time") {
            GameObject narratortext08go = Instantiate(narrator) as GameObject;
            narratortext08go.SetActive(false);
            narratortext08go.transform.parent = gameObject.transform;
            Transform narratortext08 = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext08.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you broke time."];
            Image narratortext08image = narratortext08go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext08image.color = new Color(narratortext08image.color.r, narratortext08image.color.g, narratortext08image.color.b, 0f);
            TMP_Text narratortext08text = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext08text.color = new Color(narratortext08text.color.r, narratortext08text.color.g, narratortext08text.color.b, 0f);
            narratortext08go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            if (PlayerPrefs.GetString("dressed_as") == "You asked for Grandma's help to defend Tommy and Nic") {
                GameObject narratorimage09go = Instantiate(narratorWithImage) as GameObject;
                narratorimage09go.SetActive(false);
                narratorimage09go.transform.parent = gameObject.transform;
                Transform narratorimage09 = narratorimage09go.transform.Find("Textbox container/Narrator text/Image");
                narratorimage09.GetComponent<Image>().preserveAspect = true;
                narratorimage09.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-8");
                LeanTween.alpha(narratorimage09go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
                narratorimage09go.SetActive(true);
                LeanTween.alpha(narratorimage09go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
                LeanTween.alpha(narratorimage09go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
                yield return new WaitForSeconds(0.6f);
            } else {
                GameObject narratorimage09go = Instantiate(narratorWithImage) as GameObject;
                narratorimage09go.SetActive(false);
                narratorimage09go.transform.parent = gameObject.transform;
                Transform narratorimage09 = narratorimage09go.transform.Find("Textbox container/Narrator text/Image");
                narratorimage09.GetComponent<Image>().preserveAspect = true;
                narratorimage09.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap7-8-2");
                LeanTween.alpha(narratorimage09go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
                narratorimage09go.SetActive(true);
                LeanTween.alpha(narratorimage09go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
                LeanTween.alpha(narratorimage09go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
                yield return new WaitForSeconds(0.6f);
            }
        }

        continueButton.SetActive(true);
        LeanTween.alpha(continueButton.GetComponent<RectTransform>(), 1f, 0.4f);
    }
}