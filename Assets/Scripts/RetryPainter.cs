using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class RetryPainter : MonoBehaviour
{
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject reply;
    [SerializeField]GameObject response;
    [SerializeField]GameObject continueButton;
    public static Dictionary<string, Dictionary<string, string>> highlightsTranslations;
    IEnumerator Start() {
        highlightsTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["You've reached the end."] = "You've reached the end.",
                ["Would you like to play again?"] = "Would you like to play again?",
                ["You've traced your own path."] = "You've traced your own path.",
                ["Are you completely satisfied?"] = "Are you completely satisfied?",
                ["Do you want to change anything?"] = "Do you want to change anything?",
                ["Trace it again."] = "Trace it again.",
                ["What?"] = "What?",
                ["Where am I?"] = "Where am I?",
                ["And the last one comes to me."] = "And the last one comes to me.",
                ["To us."] = "To us.",
                ["You know, crossing realities is a crime that doesn't get forgiven so easily here."] = "You know, crossing realities is a crime that doesn't get forgiven so easily here.",
                ["I should know."] = "I should know.",
                ["And I didn't even do it on purpose."] = "And I didn't even do it on purpose."
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["You've reached the end."] = "You've reached the end.",
                ["Would you like to play again?"] = "Would you like to play again?",
                ["You've traced your own path."] = "You've traced your own path.",
                ["Are you completely satisfied?"] = "Are you completely satisfied?",
                ["Do you want to change anything?"] = "Do you want to change anything?",
                ["Trace it again."] = "Trace it again.",
                ["What?"] = "What?",
                ["Where am I?"] = "Where am I?",
                ["And the last one comes to me."] = "And the last one comes to me.",
                ["To us."] = "To us.",
                ["You know, crossing realities is a crime that doesn't get forgiven so easily here."] = "You know, crossing realities is a crime that doesn't get forgiven so easily here.",
                ["I should know."] = "I should know.",
                ["And I didn't even do it on purpose."] = "And I didn't even do it on purpose."
            }
        };
        GameObject.Find("Retry title").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        yield return new WaitForSeconds(0.4f);
        
        if (PlayerPrefs.GetInt("post_credits") == 0 || PlayerPrefs.GetInt("post_credits") == 3) {
            GameObject narratortextgo = Instantiate(narrator) as GameObject;
            narratortextgo.SetActive(false);
            narratortextgo.transform.parent = gameObject.transform;
            Transform narratortext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["You've traced your own path."];
            Image narratortextimage = narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortextimage.color = new Color(narratortextimage.color.r, narratortextimage.color.g, narratortextimage.color.b, 0f);
            TMP_Text narratortexttext = narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortexttext.color = new Color(narratortexttext.color.r, narratortexttext.color.g, narratortexttext.color.b, 0f);
            narratortextgo.transform.localScale = new Vector3(1,1,1);
            narratortextgo.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortextgo.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortextgo.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratortext02go = Instantiate(narrator) as GameObject;
            narratortext02go.SetActive(false);
            narratortext02go.transform.parent = gameObject.transform;
            Transform narratortext02 = narratortext02go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["Are you completely satisfied?"];
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
            narratortext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["Do you want to change anything?"];
            Image narratortext03image = narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext03image.color = new Color(narratortext03image.color.r, narratortext03image.color.g, narratortext03image.color.b, 0f);
            TMP_Text narratortext03text = narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext03text.color = new Color(narratortext03text.color.r, narratortext03text.color.g, narratortext03text.color.b, 0f);
            narratortext03go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext03go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext03go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);

            GameObject narratortext04go = Instantiate(narrator) as GameObject;
            narratortext04go.SetActive(false);
            narratortext04go.transform.parent = gameObject.transform;
            Transform narratortext04 = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["Trace it again."];
            Image narratortext04image = narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<Image>();
            narratortext04image.color = new Color(narratortext04image.color.r, narratortext04image.color.g, narratortext04image.color.b, 0f);
            TMP_Text narratortext04text = narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>();
            narratortext04text.color = new Color(narratortext04text.color.r, narratortext04text.color.g, narratortext04text.color.b, 0f);
            narratortext04go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(narratortext04go.transform.Find("Textbox container/Narrator text").GetComponent<RectTransform>(), 1f, 0.4f);
            narratortext04go.transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetInt("post_credits") == 1) {
            GameObject replytextgo = Instantiate(reply) as GameObject;
            replytextgo.SetActive(false);
            replytextgo.transform.parent = gameObject.transform;
            Transform replytext = replytextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            replytext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["What?"];
            Image replytextimage = replytextgo.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            replytextimage.color = new Color(replytextimage.color.r, replytextimage.color.g, replytextimage.color.b, 0f);
            Image replytextavatar = replytextgo.transform.Find("Circular mask/Character image").GetComponent<Image>();
            replytextavatar.sprite = Resources.Load<Sprite>("Images/Avatar/bea_avatarQ");
            replytextavatar.color = new Color(replytextavatar.color.r, replytextavatar.color.g, replytextavatar.color.b, 0f);
            TMP_Text replytexttext = replytextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            replytexttext.color = new Color(replytexttext.color.r, replytexttext.color.g, replytexttext.color.b, 0f);
            TMP_Text replytextname = replytextgo.transform.Find("Textbox container/Textbox inner container/Player name").GetComponent<TMP_Text>();
            replytextname.color = new Color(replytextname.color.r, replytextname.color.g, replytextname.color.b, 0f);
            replytextgo.transform.localScale = new Vector3(1,1,1);
            replytextgo.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(replytextgo.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(replytextgo.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            replytextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            replytextgo.transform.Find("Textbox container/Textbox inner container/Player name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(4f);

            GameObject replytext02go = Instantiate(reply) as GameObject;
            replytext02go.SetActive(false);
            replytext02go.transform.parent = gameObject.transform;
            Transform replytext02 = replytext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            replytext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["Where am I?"];
            Image replytext02image = replytext02go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            replytext02image.color = new Color(replytext02image.color.r, replytext02image.color.g, replytext02image.color.b, 0f);
            Image replytext02avatar = replytext02go.transform.Find("Circular mask/Character image").GetComponent<Image>();
            replytext02avatar.sprite = Resources.Load<Sprite>("Images/Avatar/bea_avatarQ");
            replytext02avatar.color = new Color(replytext02avatar.color.r, replytext02avatar.color.g, replytext02avatar.color.b, 0f);
            TMP_Text replytext02text = replytext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            replytext02text.color = new Color(replytext02text.color.r, replytext02text.color.g, replytext02text.color.b, 0f);
            TMP_Text replytext02name = replytext02go.transform.Find("Textbox container/Textbox inner container/Player name").GetComponent<TMP_Text>();
            replytext02name.color = new Color(replytext02name.color.r, replytext02name.color.g, replytext02name.color.b, 0f);
            replytext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(replytext02go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(replytext02go.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            replytext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            replytext02go.transform.Find("Textbox container/Textbox inner container/Player name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(4f);

            GameObject responsetextgo = Instantiate(response) as GameObject;
            responsetextgo.SetActive(false);
            responsetextgo.transform.parent = gameObject.transform;
            Transform responsetext = responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            responsetext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["And the last one comes to me."];
            Image responsetextimage = responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            responsetextimage.color = new Color(responsetextimage.color.r, responsetextimage.color.g, responsetextimage.color.b, 0f);
            Image responsetextavatar = responsetextgo.transform.Find("Circular mask/Character image").GetComponent<Image>();
            responsetextavatar.sprite = Resources.Load<Sprite>("Images/Avatar/nero_avatarQ");
            responsetextavatar.color = new Color(responsetextavatar.color.r, responsetextavatar.color.g, responsetextavatar.color.b, 0f);
            TMP_Text responsetexttext = responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            responsetexttext.color = new Color(responsetexttext.color.r, responsetexttext.color.g, responsetexttext.color.b, 0f);
            TMP_Text responsetextname = responsetextgo.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>();
            responsetextname.color = new Color(responsetextname.color.r, responsetextname.color.g, responsetextname.color.b, 0f);
            responsetextgo.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(responsetextgo.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            responsetextgo.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(4f);

            GameObject responsetext02go = Instantiate(response) as GameObject;
            responsetext02go.SetActive(false);
            responsetext02go.transform.parent = gameObject.transform;
            Transform responsetext02 = responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            responsetext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["To us."];
            Image responsetext02image = responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            responsetext02image.color = new Color(responsetext02image.color.r, responsetext02image.color.g, responsetext02image.color.b, 0f);
            Image responsetext02avatar = responsetext02go.transform.Find("Circular mask/Character image").GetComponent<Image>();
            responsetext02avatar.sprite = Resources.Load<Sprite>("Images/Avatar/bianco_avatarQ");
            responsetext02avatar.color = new Color(responsetext02avatar.color.r, responsetext02avatar.color.g, responsetext02avatar.color.b, 0f);
            TMP_Text responsetext02text = responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            responsetext02text.color = new Color(responsetext02text.color.r, responsetext02text.color.g, responsetext02text.color.b, 0f);
            TMP_Text responsetext02name = responsetext02go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>();
            responsetext02name.color = new Color(responsetext02name.color.r, responsetext02name.color.g, responsetext02name.color.b, 0f);
            responsetext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(responsetext02go.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            responsetext02go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetInt("post_credits") == 2) {
            GameObject responsetextgo = Instantiate(response) as GameObject;
            responsetextgo.SetActive(false);
            responsetextgo.transform.parent = gameObject.transform;
            Transform responsetext = responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            responsetext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["You know, crossing realities is a crime that doesn't get forgiven so easily here."];
            Image responsetextimage = responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            responsetextimage.color = new Color(responsetextimage.color.r, responsetextimage.color.g, responsetextimage.color.b, 0f);
            Image responsetextavatar = responsetextgo.transform.Find("Circular mask/Character image").GetComponent<Image>();
            responsetextavatar.sprite = Resources.Load<Sprite>("Images/Avatar/grigio_avatarQ");
            responsetextavatar.color = new Color(responsetextavatar.color.r, responsetextavatar.color.g, responsetextavatar.color.b, 0f);
            TMP_Text responsetexttext = responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            responsetexttext.color = new Color(responsetexttext.color.r, responsetexttext.color.g, responsetexttext.color.b, 0f);
            TMP_Text responsetextname = responsetextgo.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>();
            responsetextname.color = new Color(responsetextname.color.r, responsetextname.color.g, responsetextname.color.b, 0f);
            responsetextgo.transform.localScale = new Vector3(1,1,1);
            responsetextgo.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(responsetextgo.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            responsetextgo.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(4f);

            GameObject responsetext02go = Instantiate(response) as GameObject;
            responsetext02go.SetActive(false);
            responsetext02go.transform.parent = gameObject.transform;
            Transform responsetext02 = responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            responsetext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["I should know."];
            Image responsetext02image = responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            responsetext02image.color = new Color(responsetext02image.color.r, responsetext02image.color.g, responsetext02image.color.b, 0f);
            Image responsetext02avatar = responsetext02go.transform.Find("Circular mask/Character image").GetComponent<Image>();
            responsetext02avatar.sprite = Resources.Load<Sprite>("Images/Avatar/grigio_avatarQ");
            responsetext02avatar.color = new Color(responsetext02avatar.color.r, responsetext02avatar.color.g, responsetext02avatar.color.b, 0f);
            TMP_Text responsetext02text = responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            responsetext02text.color = new Color(responsetext02text.color.r, responsetext02text.color.g, responsetext02text.color.b, 0f);
            TMP_Text responsetext02name = responsetext02go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>();
            responsetext02name.color = new Color(responsetext02name.color.r, responsetext02name.color.g, responsetext02name.color.b, 0f);
            responsetext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(responsetext02go.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            responsetext02go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(4f);

            GameObject responsetext03go = Instantiate(response) as GameObject;
            responsetext03go.SetActive(false);
            responsetext03go.transform.parent = gameObject.transform;
            Transform responsetext03 = responsetext03go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            responsetext03.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["And I didn't even do it on purpose."];
            Image responsetext03image = responsetext03go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            responsetext03image.color = new Color(responsetext03image.color.r, responsetext03image.color.g, responsetext03image.color.b, 0f);
            Image responsetext03avatar = responsetext03go.transform.Find("Circular mask/Character image").GetComponent<Image>();
            responsetext03avatar.sprite = Resources.Load<Sprite>("Images/Avatar/grigio_avatarQ");
            responsetext03avatar.color = new Color(responsetext03avatar.color.r, responsetext03avatar.color.g, responsetext03avatar.color.b, 0f);
            TMP_Text responsetext03text = responsetext03go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            responsetext03text.color = new Color(responsetext03text.color.r, responsetext03text.color.g, responsetext03text.color.b, 0f);
            TMP_Text responsetext03name = responsetext03go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>();
            responsetext03name.color = new Color(responsetext03name.color.r, responsetext03name.color.g, responsetext03name.color.b, 0f);
            responsetext03go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(responsetext03go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(responsetext03go.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            responsetext03go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            responsetext03go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(4f);

            GameObject replytextgo = Instantiate(reply) as GameObject;
            replytextgo.SetActive(false);
            replytextgo.transform.parent = gameObject.transform;
            Transform replytext = replytextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            replytext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["What?"];
            Image replytextimage = replytextgo.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            replytextimage.color = new Color(replytextimage.color.r, replytextimage.color.g, replytextimage.color.b, 0f);
            Image replytextavatar = replytextgo.transform.Find("Circular mask/Character image").GetComponent<Image>();
            replytextavatar.sprite = Resources.Load<Sprite>("Images/Avatar/bea_avatarQ");
            replytextavatar.color = new Color(replytextavatar.color.r, replytextavatar.color.g, replytextavatar.color.b, 0f);
            TMP_Text replytexttext = replytextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            replytexttext.color = new Color(replytexttext.color.r, replytexttext.color.g, replytexttext.color.b, 0f);
            TMP_Text replytextname = replytextgo.transform.Find("Textbox container/Textbox inner container/Player name").GetComponent<TMP_Text>();
            replytextname.color = new Color(replytextname.color.r, replytextname.color.g, replytextname.color.b, 0f);
            replytextgo.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(replytextgo.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(replytextgo.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            replytextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            replytextgo.transform.Find("Textbox container/Textbox inner container/Player name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(4f);

            GameObject replytext02go = Instantiate(reply) as GameObject;
            replytext02go.SetActive(false);
            replytext02go.transform.parent = gameObject.transform;
            Transform replytext02 = replytext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            replytext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["Where am I?"];
            Image replytext02image = replytext02go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            replytext02image.color = new Color(replytext02image.color.r, replytext02image.color.g, replytext02image.color.b, 0f);
            Image replytext02avatar = replytext02go.transform.Find("Circular mask/Character image").GetComponent<Image>();
            replytext02avatar.sprite = Resources.Load<Sprite>("Images/Avatar/bea_avatarQ");
            replytext02avatar.color = new Color(replytext02avatar.color.r, replytext02avatar.color.g, replytext02avatar.color.b, 0f);
            TMP_Text replytext02text = replytext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            replytext02text.color = new Color(replytext02text.color.r, replytext02text.color.g, replytext02text.color.b, 0f);
            TMP_Text replytext02name = replytext02go.transform.Find("Textbox container/Textbox inner container/Player name").GetComponent<TMP_Text>();
            replytext02name.color = new Color(replytext02name.color.r, replytext02name.color.g, replytext02name.color.b, 0f);
            replytext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(replytext02go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(replytext02go.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            replytext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            replytext02go.transform.Find("Textbox container/Textbox inner container/Player name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(4f);

            GameObject responsetext04go = Instantiate(response) as GameObject;
            responsetext04go.SetActive(false);
            responsetext04go.transform.parent = gameObject.transform;
            Transform responsetext04 = responsetext04go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            responsetext04.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["And the last one comes to me."];
            Image responsetext04image = responsetext04go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            responsetext04image.color = new Color(responsetext04image.color.r, responsetext04image.color.g, responsetext04image.color.b, 0f);
            Image responsetext04avatar = responsetext04go.transform.Find("Circular mask/Character image").GetComponent<Image>();
            responsetext04avatar.sprite = Resources.Load<Sprite>("Images/Avatar/nero_avatarQ");
            responsetext04avatar.color = new Color(responsetext04avatar.color.r, responsetext04avatar.color.g, responsetext04avatar.color.b, 0f);
            TMP_Text responsetext04text = responsetext04go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            responsetext04text.color = new Color(responsetext04text.color.r, responsetext04text.color.g, responsetext04text.color.b, 0f);
            TMP_Text responsetext04name = responsetext04go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>();
            responsetext04name.color = new Color(responsetext04name.color.r, responsetext04name.color.g, responsetext04name.color.b, 0f);
            responsetext04go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(responsetext04go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(responsetext04go.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            responsetext04go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            responsetext04go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(4f);

            GameObject responsetext05go = Instantiate(response) as GameObject;
            responsetext05go.SetActive(false);
            responsetext05go.transform.parent = gameObject.transform;
            Transform responsetext05 = responsetext05go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            responsetext05.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["To us."];
            Image responsetext05image = responsetext05go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            responsetext05image.color = new Color(responsetext05image.color.r, responsetext05image.color.g, responsetext05image.color.b, 0f);
            Image responsetext05avatar = responsetext05go.transform.Find("Circular mask/Character image").GetComponent<Image>();
            responsetext05avatar.sprite = Resources.Load<Sprite>("Images/Avatar/bianco_avatarQ");
            responsetext05avatar.color = new Color(responsetext05avatar.color.r, responsetext05avatar.color.g, responsetext05avatar.color.b, 0f);
            TMP_Text responsetext05text = responsetext05go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            responsetext05text.color = new Color(responsetext05text.color.r, responsetext05text.color.g, responsetext05text.color.b, 0f);
            TMP_Text responsetext05name = responsetext05go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>();
            responsetext05name.color = new Color(responsetext05name.color.r, responsetext05name.color.g, responsetext05name.color.b, 0f);
            responsetext05go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(responsetext05go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(responsetext05go.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            responsetext05go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            responsetext05go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(0.4f);
        } else if (PlayerPrefs.GetInt("post_credits") == 8) {
            GameObject responsetextgo = Instantiate(response) as GameObject;
            responsetextgo.SetActive(false);
            responsetextgo.transform.parent = gameObject.transform;
            Transform responsetext = responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            responsetext.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["And the last one comes to me."];
            Image responsetextimage = responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            responsetextimage.color = new Color(responsetextimage.color.r, responsetextimage.color.g, responsetextimage.color.b, 0f);
            Image responsetextavatar = responsetextgo.transform.Find("Circular mask/Character image").GetComponent<Image>();
            responsetextavatar.sprite = Resources.Load<Sprite>("Images/Avatar/nero_avatarQ");
            responsetextavatar.color = new Color(responsetextavatar.color.r, responsetextavatar.color.g, responsetextavatar.color.b, 0f);
            TMP_Text responsetexttext = responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            responsetexttext.color = new Color(responsetexttext.color.r, responsetexttext.color.g, responsetexttext.color.b, 0f);
            TMP_Text responsetextname = responsetextgo.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>();
            responsetextname.color = new Color(responsetextname.color.r, responsetextname.color.g, responsetextname.color.b, 0f);
            responsetextgo.transform.localScale = new Vector3(1,1,1);
            responsetextgo.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(responsetextgo.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            responsetextgo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            responsetextgo.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            yield return new WaitForSeconds(4f);

            GameObject responsetext02go = Instantiate(response) as GameObject;
            responsetext02go.SetActive(false);
            responsetext02go.transform.parent = gameObject.transform;
            Transform responsetext02 = responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            responsetext02.GetComponent<TMP_Text>().text = highlightsTranslations[TextLocalizer.CurrentLanguage]["To us."];
            Image responsetext02image = responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<Image>();
            responsetext02image.color = new Color(responsetext02image.color.r, responsetext02image.color.g, responsetext02image.color.b, 0f);
            Image responsetext02avatar = responsetext02go.transform.Find("Circular mask/Character image").GetComponent<Image>();
            responsetext02avatar.sprite = Resources.Load<Sprite>("Images/Avatar/bianco_avatarQ");
            responsetext02avatar.color = new Color(responsetext02avatar.color.r, responsetext02avatar.color.g, responsetext02avatar.color.b, 0f);
            TMP_Text responsetext02text = responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>();
            responsetext02text.color = new Color(responsetext02text.color.r, responsetext02text.color.g, responsetext02text.color.b, 0f);
            TMP_Text responsetext02name = responsetext02go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>();
            responsetext02name.color = new Color(responsetext02name.color.r, responsetext02name.color.g, responsetext02name.color.b, 0f);
            responsetext02go.SetActive(true);
            yield return new WaitForSeconds(0.001f);
            LeanTween.alpha(responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text").GetComponent<RectTransform>(), 1f, 0.4f);
            LeanTween.alpha(responsetext02go.transform.Find("Circular mask/Character image").GetComponent<RectTransform>(), 1f, 0.4f);
            responsetext02go.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
            responsetext02go.transform.Find("Textbox container/Textbox inner container/Character name").GetComponent<TMP_Text>().LeanAlphaText(1f, 0.4f);
        }

        continueButton.SetActive(true);
        LeanTween.alpha(continueButton.GetComponent<RectTransform>(), 1f, 0.4f);
    }
}