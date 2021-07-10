using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class NotePainter9 : MonoBehaviour
{
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        highlightsTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["...you checked on your sand level."] = "...you checked on your sand level.",
                ["...you decided to talk to Grandpa."] = "...you decided to talk to Grandpa.",
                ["...Grandpa gave you a chest with a letter from Grandma and a picture."] = "...Grandpa gave you a chest with a letter from Grandma and a picture.",
                ["...you read the letter."] = "...you read the letter.",
                ["...you didn't read the letter."] = "...you didn't read the letter.",
                ["...you travelled to the alternate reality."] = "...you travelled to the alternate reality.",
                ["...you didn't travel to the alternate reality."] = "...you didn't travel to the alternate reality.",
                ["...you met a weird younger version of yourself and she tried to hurt you..."] = "...you met a weird younger version of yourself and she tried to hurt you...",
                ["...you managed to escape."] = "...you managed to escape.",
                ["...you were absorbed by your alternative self."] = "...you were absorbed by your alternative self.",
                ["...you chose to save Grandma."] = "...you chose to save Grandma.",
                ["...you chose to save your brothers."] = "...you chose to save your brothers.",
                ["...you had the chance to save both Grandma and the twins."] = "...you had the chance to save both Grandma and the twins.",
                ["...you went to save your brothers."] = "...you went to save your brothers.",
                ["...you managed to save your brothers."] = "...you managed to save your brothers.",
                ["...you didn't manage to save your brothers."] = "...you didn't manage to save your brothers.",
                ["...you managed to save your brothers by sacrificing yourself."] = "...you managed to save your brothers by sacrificing yourself.",
                ["...you travelled back to go save Grandma."] = "...you travelled back to go save Grandma.",
                ["...Grandma wasn’t happy to see you."] = "...Grandma wasn’t happy to see you.",
                ["...you told Grandma you chose her."] = "...you told Grandma you chose her.",
                ["...you lied to Grandma and told her you had saved the twins."] = "...you lied to Grandma and told her you had saved the twins.",
                ["...Grandma wasn't happy with your choice."] = "...Grandma wasn't happy with your choice.",
                ["...you didn't convince her to come with you."] = "...you didn't convince her to come with you.",
                ["...you let her sacrifice herself for past Beatrice."] = "...you let her sacrifice herself for past Beatrice.",
                ["...you chose to sacrifice yourself to save Grandma and past Beatrice."] = "...you chose to sacrifice yourself to save Grandma and past Beatrice.",
                ["...you convinced Grandma to come with you and, together, you ran away from your family."] = "...you convinced Grandma to come with you and, together, you ran away from your family.",
                ["...you travelled back to the present and visited Grandma's grave."] = "...you travelled back to the present and visited Grandma's grave.",
                ["...you ran away from your family."] = "...you ran away from your family.",
                ["...you decided to go back to your family and you moved on."] = "...you decided to go back to your family and you moved on.",
                ["...you decided to travel alone through time."] = "...you decided to travel alone through time."
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["...you checked on your sand level."] = "...hai controllato il tuo livello di sabbia.",
                ["...you decided to talk to Grandpa."] = "...hai deciso di parlare con il nonno.",
                ["...Grandpa gave you a chest with a letter from Grandma and a picture."] = "...il nonno ti ha dato uno scrigno con una lettera da parte della nonna e una foto.",
                ["...you read the letter."] = "...hai letto la lettera.",
                ["...you didn't read the letter."] = "...non hai letto la lettera.",
                ["...you travelled to the alternate reality."] = "...hai viaggiato nella realtà alternativa.",
                ["...you didn't travel to the alternate reality."] = "...non hai viaggiato nella realtà alternativa.",
                ["...you met a weird younger version of yourself and she tried to hurt you..."] = "...hai incontrato una strana versione più giovane di te stessa e lei ha provato a farti del male...",
                ["...you managed to escape."] = "...sei riuscita a scappare.",
                ["...you were absorbed by your alternative self."] = "...sei stata assorbita dalla te stessa della realtà alternativa.",
                ["...you chose to save Grandma."] = "...hai scelto di salvare la nonna.",
                ["...you chose to save your brothers."] = "...hai scelto di salvare i tuoi fratelli.",
                ["...you had the chance to save both Grandma and the twins."] = "...hai avuto l'occasione di salvare sia la nonna sia i gemelli.",
                ["...you went to save your brothers."] = "...sei andata a salvare i tuoi fratelli.",
                ["...you managed to save your brothers."] = "...sei riuscita a salvare i tuoi fratelli.",
                ["...you didn't manage to save your brothers."] = "...non sei riuscita a salvare i tuoi fratelli.",
                ["...you managed to save your brothers by sacrificing yourself."] = "...sei riuscita a salvare i tuoi fratelli sacrificando te stessa.",
                ["...you travelled back to the present and visited Grandma's grave."] = "...hai viaggiato ritornando nel presente e hai visitato la tomba della nonna.",
                ["...you ran away from your family."] = "...sei corsa via dalla tua famiglia.",
                ["...you decided to go back to your family and you moved on."] = "...hai deciso di tornare dalla tua famiglia e sei andata avanti.",
                ["...you decided to travel alone through time."] = "...hai deciso di viaggiare da sola nel tempo.",
                ["...you told Grandma you chose her."] = "...hai detto alla nonna che hai scelto lei.",
                ["...you lied to Grandma and told her you had saved the twins."] = "...hai ingannato la nonna e le hai detto che hai salvato i gemelli.",
                ["...Grandma wasn't happy with your choice."] = "...la nonna non è stata contenta della tua scelta.",
                ["...you didn't convince her to come with you."] = "...non l'hai convinta di venire con te.",
                ["...you let her sacrifice herself for past Beatrice."] = "...hai lasciato che lei si sacrificasse per la Beatrice del passato",
                ["...you chose to sacrifice yourself to save Grandma and past Beatrice."] = "...hai scelto di sacrificare te stessa per salvare la nonna e la Beatrice del passato.",
                ["...you convinced Grandma to come with you and, together, you ran away from your family."] = "...hai convinto la nonna di venire con te e, insieme, siete corsi via dalla vostra famiglia.",
                ["...you travelled back to go save Grandma."] = "...hai viaggiato indietro nel tempo per andare a salvare la nonna.",
                ["...Grandma wasn’t happy to see you."] = "...la nonna non è stata contenta di vederti."
            }
        };
        GameObject.Find("Ending title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        GameObject narratortextgo = Instantiate(narrator) as GameObject;
        narratortextgo.SetActive(false);
        narratortextgo.transform.parent = gameObject.transform;
        Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you checked on your sand level."];
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
        narratorimage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-1-"+PlayerPrefs.GetString("sand_level"));
        LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
        narratorimagego.SetActive(true);
        LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
        LeanTween.alpha(narratorimagego.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
        yield return new WaitForSeconds(0.6f);
        
        if (PlayerPrefs.GetString("talk_to_Grandpa") == "You decided to talk to Grandpa") {
            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you decided to talk to Grandpa."];
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

        if (PlayerPrefs.GetString("chest_from_Grandpa") == "Grandpa gave you a chest with a letter from Grandma and a picture") {
            GameObject narratortext03go = Instantiate(narrator) as GameObject;
            narratortext03go.SetActive(false);
            narratortext03go.transform.parent = gameObject.transform;
            Transform narratortext03 = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...Grandpa gave you a chest with a letter from Grandma and a picture."];
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
            narratorimage02.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-2");
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage02go.SetActive(true);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage02go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        if (PlayerPrefs.GetString("letter_read") == "You read the letter") {
            GameObject narratortext04go = Instantiate(narrator) as GameObject;
            narratortext04go.SetActive(false);
            narratortext04go.transform.parent = gameObject.transform;
            Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you read the letter."];
            Image narratortext04image = narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext04image.color = new Color(narratortext04image.color.r, narratortext04image.color.g, narratortext04image.color.b, 0f);
            TMP_Text narratortext04text = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext04text.color = new Color(narratortext04text.color.r, narratortext04text.color.g, narratortext04text.color.b, 0f);
            narratortext04go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("letter_read") == "You didn't read the letter") {
            GameObject narratortext04go = Instantiate(narrator) as GameObject;
            narratortext04go.SetActive(false);
            narratortext04go.transform.parent = gameObject.transform;
            Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you didn't read the letter."];
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

        if (PlayerPrefs.GetInt("alternate_reality") == 1) {
            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you travelled to the alternate reality."];
            Image narratortext05image = narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext05image.color = new Color(narratortext05image.color.r, narratortext05image.color.g, narratortext05image.color.b, 0f);
            TMP_Text narratortext05text = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext05text.color = new Color(narratortext05text.color.r, narratortext05text.color.g, narratortext05text.color.b, 0f);
            narratortext05go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratortext06go = Instantiate(narrator) as GameObject;
            narratortext06go.SetActive(false);
            narratortext06go.transform.parent = gameObject.transform;
            Transform narratortext06 = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext06.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you met a weird younger version of yourself and she tried to hurt you..."];
            Image narratortext06image = narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext06image.color = new Color(narratortext06image.color.r, narratortext06image.color.g, narratortext06image.color.b, 0f);
            TMP_Text narratortext06text = narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext06text.color = new Color(narratortext06text.color.r, narratortext06text.color.g, narratortext06text.color.b, 0f);
            narratortext06go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext06go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage03go = Instantiate(narratorWithImage) as GameObject;
            narratorimage03go.SetActive(false);
            narratorimage03go.transform.parent = gameObject.transform;
            Transform narratorimage03 = narratorimage03go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage03.GetComponent<Image>().preserveAspect = true;
            narratorimage03.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-3");
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage03go.SetActive(true);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage03go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else {
            GameObject narratortext05go = Instantiate(narrator) as GameObject;
            narratortext05go.SetActive(false);
            narratortext05go.transform.parent = gameObject.transform;
            Transform narratortext05 = narratortext05go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you didn't travel to the alternate reality."];
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

        if (PlayerPrefs.GetString("escape") == "You managed to escape") {
            GameObject narratortext07go = Instantiate(narrator) as GameObject;
            narratortext07go.SetActive(false);
            narratortext07go.transform.parent = gameObject.transform;
            Transform narratortext07 = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext07.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you managed to escape."];
            Image narratortext07image = narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext07image.color = new Color(narratortext07image.color.r, narratortext07image.color.g, narratortext07image.color.b, 0f);
            TMP_Text narratortext07text = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext07text.color = new Color(narratortext07text.color.r, narratortext07text.color.g, narratortext07text.color.b, 0f);
            narratortext07go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("escape") == "You were absorbed by your alternative self") {
            GameObject narratortext07go = Instantiate(narrator) as GameObject;
            narratortext07go.SetActive(false);
            narratortext07go.transform.parent = gameObject.transform;
            Transform narratortext07 = narratortext07go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext07.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you were absorbed by your alternative self."];
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

        if (PlayerPrefs.GetString("save_choice") == "You chose to save your brothers") {
            GameObject narratortext08go = Instantiate(narrator) as GameObject;
            narratortext08go.SetActive(false);
            narratortext08go.transform.parent = gameObject.transform;
            Transform narratortext08 = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext08.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you chose to save your brothers."];
            Image narratortext08image = narratortext08go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext08image.color = new Color(narratortext08image.color.r, narratortext08image.color.g, narratortext08image.color.b, 0f);
            TMP_Text narratortext08text = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext08text.color = new Color(narratortext08text.color.r, narratortext08text.color.g, narratortext08text.color.b, 0f);
            narratortext08go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("save_choice") == "You chose to save Grandma") {
            GameObject narratortext08go = Instantiate(narrator) as GameObject;
            narratortext08go.SetActive(false);
            narratortext08go.transform.parent = gameObject.transform;
            Transform narratortext08 = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext08.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you chose to save Grandma."];
            Image narratortext08image = narratortext08go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext08image.color = new Color(narratortext08image.color.r, narratortext08image.color.g, narratortext08image.color.b, 0f);
            TMP_Text narratortext08text = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext08text.color = new Color(narratortext08text.color.r, narratortext08text.color.g, narratortext08text.color.b, 0f);
            narratortext08go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage04go = Instantiate(narratorWithImage) as GameObject;
            narratorimage04go.SetActive(false);
            narratorimage04go.transform.parent = gameObject.transform;
            Transform narratorimage04 = narratorimage04go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage04.GetComponent<Image>().preserveAspect = true;
            narratorimage04.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-12");
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage04go.SetActive(true);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage04go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("save_choice") == "You had the chance to save both Grandma and the twins") {
            GameObject narratortext08go = Instantiate(narrator) as GameObject;
            narratortext08go.SetActive(false);
            narratortext08go.transform.parent = gameObject.transform;
            Transform narratortext08 = narratortext08go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext08.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you had the chance to save both Grandma and the twins."];
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

        if (PlayerPrefs.GetString("save_brothers") == "You went to save your brothers") {
            GameObject narratortext09go = Instantiate(narrator) as GameObject;
            narratortext09go.SetActive(false);
            narratortext09go.transform.parent = gameObject.transform;
            Transform narratortext09 = narratortext09go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext09.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you went to save your brothers."];
            Image narratortext09image = narratortext09go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext09image.color = new Color(narratortext09image.color.r, narratortext09image.color.g, narratortext09image.color.b, 0f);
            TMP_Text narratortext09text = narratortext09go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext09text.color = new Color(narratortext09text.color.r, narratortext09text.color.g, narratortext09text.color.b, 0f);
            narratortext09go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext09go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext09go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        if (PlayerPrefs.GetString("manage_brothers") == "You managed to save your brothers") {
            GameObject narratortext10go = Instantiate(narrator) as GameObject;
            narratortext10go.SetActive(false);
            narratortext10go.transform.parent = gameObject.transform;
            Transform narratortext10 = narratortext10go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext10.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you managed to save your brothers."];
            Image narratortext10image = narratortext10go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext10image.color = new Color(narratortext10image.color.r, narratortext10image.color.g, narratortext10image.color.b, 0f);
            TMP_Text narratortext10text = narratortext10go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext10text.color = new Color(narratortext10text.color.r, narratortext10text.color.g, narratortext10text.color.b, 0f);
            narratortext10go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext10go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext10go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage05go = Instantiate(narratorWithImage) as GameObject;
            narratorimage05go.SetActive(false);
            narratorimage05go.transform.parent = gameObject.transform;
            Transform narratorimage05 = narratorimage05go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage05.GetComponent<Image>().preserveAspect = true;
            narratorimage05.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-4");
            LeanTween.alpha(narratorimage05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage05go.SetActive(true);
            LeanTween.alpha(narratorimage05go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage05go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("manage_brothers") == "You managed to save your brothers by sacrificing yourself") {
            GameObject narratortext10go = Instantiate(narrator) as GameObject;
            narratortext10go.SetActive(false);
            narratortext10go.transform.parent = gameObject.transform;
            Transform narratortext10 = narratortext10go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext10.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you managed to save your brothers by sacrificing yourself."];
            Image narratortext10image = narratortext10go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext10image.color = new Color(narratortext10image.color.r, narratortext10image.color.g, narratortext10image.color.b, 0f);
            TMP_Text narratortext10text = narratortext10go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext10text.color = new Color(narratortext10text.color.r, narratortext10text.color.g, narratortext10text.color.b, 0f);
            narratortext10go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext10go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext10go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage06go = Instantiate(narratorWithImage) as GameObject;
            narratorimage06go.SetActive(false);
            narratorimage06go.transform.parent = gameObject.transform;
            Transform narratorimage06 = narratorimage06go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage06.GetComponent<Image>().preserveAspect = true;
            narratorimage06.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-8");
            LeanTween.alpha(narratorimage06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage06go.SetActive(true);
            LeanTween.alpha(narratorimage06go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage06go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("manage_brothers") == "You didn't manage to save your brothers") {
            GameObject narratortext10go = Instantiate(narrator) as GameObject;
            narratortext10go.SetActive(false);
            narratortext10go.transform.parent = gameObject.transform;
            Transform narratortext10 = narratortext10go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext10.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you didn't manage to save your brothers."];
            Image narratortext10image = narratortext10go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext10image.color = new Color(narratortext10image.color.r, narratortext10image.color.g, narratortext10image.color.b, 0f);
            TMP_Text narratortext10text = narratortext10go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext10text.color = new Color(narratortext10text.color.r, narratortext10text.color.g, narratortext10text.color.b, 0f);
            narratortext10go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext10go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext10go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        if (PlayerPrefs.GetString("travel_to_Grandma") == "You travelled back to go save Grandma") {
            GameObject narratortext11go = Instantiate(narrator) as GameObject;
            narratortext11go.SetActive(false);
            narratortext11go.transform.parent = gameObject.transform;
            Transform narratortext11 = narratortext11go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext11.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you travelled back to go save Grandma."];
            Image narratortext11image = narratortext11go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext11image.color = new Color(narratortext11image.color.r, narratortext11image.color.g, narratortext11image.color.b, 0f);
            TMP_Text narratortext11text = narratortext11go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext11text.color = new Color(narratortext11text.color.r, narratortext11text.color.g, narratortext11text.color.b, 0f);
            narratortext11go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext11go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext11go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratortext12go = Instantiate(narrator) as GameObject;
            narratortext12go.SetActive(false);
            narratortext12go.transform.parent = gameObject.transform;
            Transform narratortext12 = narratortext12go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext12.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...Grandma wasn’t happy to see you."];
            Image narratortext12image = narratortext12go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext12image.color = new Color(narratortext12image.color.r, narratortext12image.color.g, narratortext12image.color.b, 0f);
            TMP_Text narratortext12text = narratortext12go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext12text.color = new Color(narratortext12text.color.r, narratortext12text.color.g, narratortext12text.color.b, 0f);
            narratortext12go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext12go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext12go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        if (PlayerPrefs.GetString("action_with_Grandma") == "You told Grandma you chose her") {
            GameObject narratortext13go = Instantiate(narrator) as GameObject;
            narratortext13go.SetActive(false);
            narratortext13go.transform.parent = gameObject.transform;
            Transform narratortext13 = narratortext13go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext13.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you told Grandma you chose her."];
            Image narratortext13image = narratortext13go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext13image.color = new Color(narratortext13image.color.r, narratortext13image.color.g, narratortext13image.color.b, 0f);
            TMP_Text narratortext13text = narratortext13go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext13text.color = new Color(narratortext13text.color.r, narratortext13text.color.g, narratortext13text.color.b, 0f);
            narratortext13go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext13go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext13go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("action_with_Grandma") == "You lied to Grandma and told her you had saved the twins") {
            GameObject narratortext13go = Instantiate(narrator) as GameObject;
            narratortext13go.SetActive(false);
            narratortext13go.transform.parent = gameObject.transform;
            Transform narratortext13 = narratortext13go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext13.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you lied to Grandma and told her you had saved the twins."];
            Image narratortext13image = narratortext13go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext13image.color = new Color(narratortext13image.color.r, narratortext13image.color.g, narratortext13image.color.b, 0f);
            TMP_Text narratortext13text = narratortext13go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext13text.color = new Color(narratortext13text.color.r, narratortext13text.color.g, narratortext13text.color.b, 0f);
            narratortext13go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext13go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext13go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        if (PlayerPrefs.GetString("Grandma_choice") == "Grandma wasn't happy with your choice") {
            GameObject narratortext14go = Instantiate(narrator) as GameObject;
            narratortext14go.SetActive(false);
            narratortext14go.transform.parent = gameObject.transform;
            Transform narratortext14 = narratortext14go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext14.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...Grandma wasn't happy with your choice."];
            Image narratortext14image = narratortext14go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext14image.color = new Color(narratortext14image.color.r, narratortext14image.color.g, narratortext14image.color.b, 0f);
            TMP_Text narratortext14text = narratortext14go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext14text.color = new Color(narratortext14text.color.r, narratortext14text.color.g, narratortext14text.color.b, 0f);
            narratortext14go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext14go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext14go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        }

        if (PlayerPrefs.GetString("convince_Grandma") == "You didn't convince her to come with you") {
            GameObject narratortext15go = Instantiate(narrator) as GameObject;
            narratortext15go.SetActive(false);
            narratortext15go.transform.parent = gameObject.transform;
            Transform narratortext15 = narratortext15go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext15.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you didn't convince her to come with you."];
            Image narratortext15image = narratortext15go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext15image.color = new Color(narratortext15image.color.r, narratortext15image.color.g, narratortext15image.color.b, 0f);
            TMP_Text narratortext15text = narratortext15go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext15text.color = new Color(narratortext15text.color.r, narratortext15text.color.g, narratortext15text.color.b, 0f);
            narratortext15go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext15go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext15go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("convince_Grandma") == "You convinced Grandma to come with you and, together, you ran away from your family.") {
            GameObject narratortext15go = Instantiate(narrator) as GameObject;
            narratortext15go.SetActive(false);
            narratortext15go.transform.parent = gameObject.transform;
            Transform narratortext15 = narratortext15go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext15.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you convinced Grandma to come with you and, together, you ran away from your family."];
            Image narratortext15image = narratortext15go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext15image.color = new Color(narratortext15image.color.r, narratortext15image.color.g, narratortext15image.color.b, 0f);
            TMP_Text narratortext15text = narratortext15go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext15text.color = new Color(narratortext15text.color.r, narratortext15text.color.g, narratortext15text.color.b, 0f);
            narratortext15go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext15go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext15go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage07go = Instantiate(narratorWithImage) as GameObject;
            narratorimage07go.SetActive(false);
            narratorimage07go.transform.parent = gameObject.transform;
            Transform narratorimage07 = narratorimage07go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage07.GetComponent<Image>().preserveAspect = true;
            narratorimage07.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-14");
            LeanTween.alpha(narratorimage07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage07go.SetActive(true);
            LeanTween.alpha(narratorimage07go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage07go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        if (PlayerPrefs.GetString("sacrifice_Grandma") == "You let her sacrifice herself for past Beatrice") {
            GameObject narratortext16go = Instantiate(narrator) as GameObject;
            narratortext16go.SetActive(false);
            narratortext16go.transform.parent = gameObject.transform;
            Transform narratortext16 = narratortext16go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext16.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you let her sacrifice herself for past Beatrice."];
            Image narratortext16image = narratortext16go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext16image.color = new Color(narratortext16image.color.r, narratortext16image.color.g, narratortext16image.color.b, 0f);
            TMP_Text narratortext16text = narratortext16go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext16text.color = new Color(narratortext16text.color.r, narratortext16text.color.g, narratortext16text.color.b, 0f);
            narratortext16go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext16go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext16go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetString("sacrifice_Grandma") == "You chose to sacrifice yourself to save Grandma and past Beatrice") {
            GameObject narratortext16go = Instantiate(narrator) as GameObject;
            narratortext16go.SetActive(false);
            narratortext16go.transform.parent = gameObject.transform;
            Transform narratortext16 = narratortext16go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext16.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you chose to sacrifice yourself to save Grandma and past Beatrice."];
            Image narratortext16image = narratortext16go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext16image.color = new Color(narratortext16image.color.r, narratortext16image.color.g, narratortext16image.color.b, 0f);
            TMP_Text narratortext16text = narratortext16go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext16text.color = new Color(narratortext16text.color.r, narratortext16text.color.g, narratortext16text.color.b, 0f);
            narratortext16go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext16go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext16go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage08go = Instantiate(narratorWithImage) as GameObject;
            narratorimage08go.SetActive(false);
            narratorimage08go.transform.parent = gameObject.transform;
            Transform narratorimage08 = narratorimage08go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage08.GetComponent<Image>().preserveAspect = true;
            narratorimage08.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-13");
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage08go.SetActive(true);
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage08go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }

        if (PlayerPrefs.GetString("final_decision") == "You travelled back to the present and visited Grandma's grave") {
            GameObject narratortext17go = Instantiate(narrator) as GameObject;
            narratortext17go.SetActive(false);
            narratortext17go.transform.parent = gameObject.transform;
            Transform narratortext17 = narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext17.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you travelled back to the present and visited Grandma's grave."];
            Image narratortext17image = narratortext17go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext17image.color = new Color(narratortext17image.color.r, narratortext17image.color.g, narratortext17image.color.b, 0f);
            TMP_Text narratortext17text = narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext17text.color = new Color(narratortext17text.color.r, narratortext17text.color.g, narratortext17text.color.b, 0f);
            narratortext17go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext17go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage09go = Instantiate(narratorWithImage) as GameObject;
            narratorimage09go.SetActive(false);
            narratorimage09go.transform.parent = gameObject.transform;
            Transform narratorimage09 = narratorimage09go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage09.GetComponent<Image>().preserveAspect = true;
            narratorimage09.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-6");
            LeanTween.alpha(narratorimage09go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage09go.SetActive(true);
            LeanTween.alpha(narratorimage09go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage09go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("final_decision") == "You ran away from your family") {
            GameObject narratortext17go = Instantiate(narrator) as GameObject;
            narratortext17go.SetActive(false);
            narratortext17go.transform.parent = gameObject.transform;
            Transform narratortext17 = narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext17.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you ran away from your family."];
            Image narratortext17image = narratortext17go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext17image.color = new Color(narratortext17image.color.r, narratortext17image.color.g, narratortext17image.color.b, 0f);
            TMP_Text narratortext17text = narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext17text.color = new Color(narratortext17text.color.r, narratortext17text.color.g, narratortext17text.color.b, 0f);
            narratortext17go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext17go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
            
            if (PlayerPrefs.GetInt("alternate_reality") == 1) {
                GameObject narratorimage10go = Instantiate(narratorWithImage) as GameObject;
                narratorimage10go.SetActive(false);
                narratorimage10go.transform.parent = gameObject.transform;
                Transform narratorimage10 = narratorimage10go.transform.Find("Textbox container/Narrator text/Image");
                narratorimage10.GetComponent<Image>().preserveAspect = true;
                narratorimage10.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-7");
                LeanTween.alpha(narratorimage10go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
                narratorimage10go.SetActive(true);
                LeanTween.alpha(narratorimage10go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
                LeanTween.alpha(narratorimage10go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
                yield return new WaitForSeconds(0.6f);
            } else {
                GameObject narratorimage11go = Instantiate(narratorWithImage) as GameObject;
                narratorimage11go.SetActive(false);
                narratorimage11go.transform.parent = gameObject.transform;
                Transform narratorimage11 = narratorimage11go.transform.Find("Textbox container/Narrator text/Image");
                narratorimage11.GetComponent<Image>().preserveAspect = true;
                narratorimage11.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-7-2");
                LeanTween.alpha(narratorimage11go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
                narratorimage11go.SetActive(true);
                LeanTween.alpha(narratorimage11go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
                LeanTween.alpha(narratorimage11go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
                yield return new WaitForSeconds(0.6f);
            }
        } else if (PlayerPrefs.GetString("final_decision") == "You decided to go back to your family and you moved on") {
            GameObject narratortext17go = Instantiate(narrator) as GameObject;
            narratortext17go.SetActive(false);
            narratortext17go.transform.parent = gameObject.transform;
            Transform narratortext17 = narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext17.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you decided to go back to your family and you moved on."];
            Image narratortext17image = narratortext17go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext17image.color = new Color(narratortext17image.color.r, narratortext17image.color.g, narratortext17image.color.b, 0f);
            TMP_Text narratortext17text = narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext17text.color = new Color(narratortext17text.color.r, narratortext17text.color.g, narratortext17text.color.b, 0f);
            narratortext17go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext17go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage12go = Instantiate(narratorWithImage) as GameObject;
            narratorimage12go.SetActive(false);
            narratorimage12go.transform.parent = gameObject.transform;
            Transform narratorimage12 = narratorimage12go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage12.GetComponent<Image>().preserveAspect = true;
            narratorimage12.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-11-2");
            LeanTween.alpha(narratorimage12go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage12go.SetActive(true);
            LeanTween.alpha(narratorimage12go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage12go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        } else if (PlayerPrefs.GetString("final_decision") == "You decided to travel alone through time") {
            GameObject narratortext17go = Instantiate(narrator) as GameObject;
            narratortext17go.SetActive(false);
            narratortext17go.transform.parent = gameObject.transform;
            Transform narratortext17 = narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext17.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["...you decided to travel alone through time."];
            Image narratortext17image = narratortext17go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext17image.color = new Color(narratortext17image.color.r, narratortext17image.color.g, narratortext17image.color.b, 0f);
            TMP_Text narratortext17text = narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext17text.color = new Color(narratortext17text.color.r, narratortext17text.color.g, narratortext17text.color.b, 0f);
            narratortext17go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext17go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext17go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratorimage13go = Instantiate(narratorWithImage) as GameObject;
            narratorimage13go.SetActive(false);
            narratorimage13go.transform.parent = gameObject.transform;
            Transform narratorimage13 = narratorimage13go.transform.Find("Textbox container/Narrator text/Image");
            narratorimage13.GetComponent<Image>().preserveAspect = true;
            narratorimage13.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+"cap8-10");
            LeanTween.alpha(narratorimage13go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 0f, 0f);
            narratorimage13go.SetActive(true);
            LeanTween.alpha(narratorimage13go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f).setRecursive(false);
            LeanTween.alpha(narratorimage13go.transform.Find("Textbox container/Narrator text/Image").GetComponent<RectTransform>(), 1f, 0.4f).setDelay(0.2f);
            yield return new WaitForSeconds(0.6f);
        }
    }
}