using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class Option8Selected : MonoBehaviour
{
    [SerializeField]GameObject reply;
    [SerializeField]GameObject replyVoiceover;
    [SerializeField]GameObject response;
    [SerializeField]GameObject responseWithImage;
    [SerializeField]GameObject responseWithAffinity;
    public Sprite heart;
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    [SerializeField]GameObject secondReplyOption;
    [SerializeField]GameObject thirdReplyOption;
    [SerializeField]GameObject confetti;
    [SerializeField]GameObject affinityTooltip;
    [SerializeField]GameObject fade;
    [SerializeField]AudioSource messageSound;
    [SerializeField]AudioSource achievementSound;
    public bool selectionPossible = true;
    public static bool avatarClicked = false;
    float continueTime = Time.time + 2;
    public static Dictionary<string, Color32> avatarColors;
    public static Dictionary<string, Dictionary<string, string>> avatarNamesTranslations;
    public static int grandpaAffinity;
    public static int grandmaAffinity;
    public static int dadAffinity;
    public static int mumAffinity;
    public static int nicAffinity;
    public static int tommyAffinity;
    public static int daveAffinity;
    public static GameObject affinityTooltipgo;
    public TextAsset prologueInkJSON;
    public static Story prologueStory;
    ScrollRect scrollrect;
    bool blockScrolling;
    float timeAfterTap = 0f;
    bool sceneOverlap;
    void Awake() {
        grandpaAffinity = PlayerPrefs.GetInt("grandpaAffinity", 6);
        grandmaAffinity = PlayerPrefs.GetInt("grandmaAffinity", 8);
        dadAffinity = PlayerPrefs.GetInt("dadAffinity", 5);
        mumAffinity = PlayerPrefs.GetInt("mumAffinity", 4);
        nicAffinity = PlayerPrefs.GetInt("nicAffinity", 4);
        tommyAffinity = PlayerPrefs.GetInt("tommyAffinity", 4);
        daveAffinity = PlayerPrefs.GetInt("daveAffinity", 5);
        if (!PlayerPrefs.HasKey("images")) {
            PlayerPrefs.SetString("images", "");
        }
        UnlockImage.images = new List<Sprite>();
        string[] imagesNames = PlayerPrefs.GetString("images").Split('|');
        foreach (string img in imagesNames) {
            UnlockImage.images.Add(Resources.Load<Sprite>("Images/Gallery/"+img));
        }
        if (!PlayerPrefs.HasKey("achievements")) {
            PlayerPrefs.SetString("achievements", "");
        }
        avatarColors = new Dictionary<string, Color32>();
        avatarColors.Add("nonno_avatarQ", new Color32(72, 19, 105, 255));
        avatarColors.Add("papà_avatarQ", new Color32(188, 69, 134, 255));
        avatarColors.Add("mamma_avatarQ", new Color32(83, 143, 197, 255));
        avatarColors.Add("nicholas_avatarQ", new Color32(83, 143, 197, 255));
        avatarColors.Add("tommy_avatarQ", new Color32(188, 69, 134, 255));
        avatarColors.Add("nonna2_avatarQ", new Color32(248, 224, 115, 255));
        avatarColors.Add("nonna70_avatarQ", new Color32(248, 224, 115, 255));
        avatarColors.Add("dave_avatarQ", new Color32(248, 224, 115, 255));
        avatarColors.Add("segretaria_avatarQ", new Color32(83, 143, 197, 255));
        avatarColors.Add("pastbea_avatarQ", new Color32(0, 0, 0, 255));
        avatarNamesTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["nonno_avatarQ"] = "Grandpa",
                ["nonna2_avatarQ"] = "Grandma",
                ["nonna70_avatarQ"] = "Grandma",
                ["papà_avatarQ"] = "Dad",
                ["mamma_avatarQ"] = "Mom",
                ["nicholas_avatarQ"] = "Nicholas",
                ["tommy_avatarQ"] = "Tommy",
                ["dave_avatarQ"] = "Dave",
                ["segretaria_avatarQ"] = "Secretary",
                ["pastbea_avatarQ"] = "Beatrice"
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["nonno_avatarQ"] = "Nonno",
                ["nonna2_avatarQ"] = "Nonna",
                ["nonna70_avatarQ"] = "Nonna",
                ["papà_avatarQ"] = "Papà",
                ["mamma_avatarQ"] = "Mamma",
                ["nicholas_avatarQ"] = "Nicholas",
                ["tommy_avatarQ"] = "Tommy",
                ["dave_avatarQ"] = "Dave",
                ["segretaria_avatarQ"] = "Segretaria",
                ["pastbea_avatarQ"] = "Beatrice"
            }
        };
        blockScrolling = false;
        StartCoroutine(ScrollDown());
    }
    public IEnumerator Start() {
        scrollrect = GameObject.Find("Scroll View 8").GetComponent<ScrollRect>();
        prologueStory = new Story(prologueInkJSON.text);
        prologueStory.variablesState["grandma_dead"] = PlayerPrefs.GetInt("grandma_dead", 0);
        prologueStory.variablesState["drowning"] = PlayerPrefs.GetString("drowning");
        yield return LoadStoryChunk();
        yield return new WaitForSeconds(0.66f);
        blockScrolling = false;
        yield return ScrollDown();
    }
    void Update() {
        if (SceneManager.GetSceneByName("IshakProfile").isLoaded || SceneManager.GetSceneByName("PlayerProfile").isLoaded) {
            sceneOverlap = true;
        } else {
            sceneOverlap = false;
        }
        if (scrollrect.verticalNormalizedPosition < 0.025) {
            blockScrolling = false;
        } else {
            if(EventSystem.current.currentSelectedGameObject!=null && EventSystem.current.currentSelectedGameObject.name=="Hourglass button") {
                blockScrolling = false;
            } else {
                blockScrolling = true;
            }
        }
    }
    public IEnumerator PaintFirstReply(string replyString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        GameObject replygo = Instantiate(reply) as GameObject;
        replygo.SetActive(false);
        replygo.transform.parent = GameObject.Find("Content").transform;
        Transform replytext = replygo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform replyavatar = replygo.transform.Find("Circular mask/Character image");
        replytext.GetComponent<TextLocalizer>().id = replyString;
        replytext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(replyString);
        if (avatar) {
            replyavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        replygo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintReply(string replyString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return waitForSkip();
        GameObject replygo = Instantiate(reply) as GameObject;
        replygo.SetActive(false);
        replygo.transform.parent = GameObject.Find("Content").transform;
        Transform replytext = replygo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform replyavatar = replygo.transform.Find("Circular mask/Character image");
        replytext.GetComponent<TextLocalizer>().id = replyString;
        replytext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(replyString);
        if (avatar) {
            replyavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        replygo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintSlowReply(string replyString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return slowWaitForSkip();
        GameObject replygo = Instantiate(reply) as GameObject;
        replygo.SetActive(false);
        replygo.transform.parent = GameObject.Find("Content").transform;
        Transform replytext = replygo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform replyavatar = replygo.transform.Find("Circular mask/Character image");
        replytext.GetComponent<TextLocalizer>().id = replyString;
        replytext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(replyString);
        if (avatar) {
            replyavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        replygo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintFirstReplyVoiceover(string replyString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        GameObject replygo = Instantiate(replyVoiceover) as GameObject;
        replygo.SetActive(false);
        replygo.transform.parent = GameObject.Find("Content").transform;
        Transform replytext = replygo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform replyavatar = replygo.transform.Find("Circular mask/Character image");
        replytext.GetComponent<TextLocalizer>().id = replyString;
        replytext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(replyString);
        if (avatar) {
            replyavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        replygo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintReplyVoiceover(string replyString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return waitForSkip();
        GameObject replygo = Instantiate(replyVoiceover) as GameObject;
        replygo.SetActive(false);
        replygo.transform.parent = GameObject.Find("Content").transform;
        Transform replytext = replygo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform replyavatar = replygo.transform.Find("Circular mask/Character image");
        replytext.GetComponent<TextLocalizer>().id = replyString;
        replytext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(replyString);
        if (avatar) {
            replyavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        replygo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintSlowReplyVoiceover(string replyString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return slowWaitForSkip();
        GameObject replygo = Instantiate(replyVoiceover) as GameObject;
        replygo.SetActive(false);
        replygo.transform.parent = GameObject.Find("Content").transform;
        Transform replytext = replygo.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform replyavatar = replygo.transform.Find("Circular mask/Character image");
        replytext.GetComponent<TextLocalizer>().id = replyString;
        replytext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(replyString);
        if (avatar) {
            replyavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        replygo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    
    public IEnumerator PaintFirstResponse(string responseString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        GameObject responsego = Instantiate(response) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<TextLocalizer>().id = responseString;
        responsetext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(responseString);
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        responsego.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintResponse(string responseString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return waitForSkip();
        GameObject responsego = Instantiate(response) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<TextLocalizer>().id = responseString;
        responsetext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(responseString);
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        responsego.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintSlowResponse(string responseString, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return slowWaitForSkip();
        GameObject responsego = Instantiate(response) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<TextLocalizer>().id = responseString;
        responsetext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(responseString);
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        responsego.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintResponseWithImage(Sprite image, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return waitForSkip();
        GameObject responsego = Instantiate(responseWithImage) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Image");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<Image>().preserveAspect = true;
        responsetext.GetComponent<Image>().sprite = image;
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        responsego.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintSlowResponseWithImage(Sprite image, Sprite avatar) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return slowWaitForSkip();
        GameObject responsego = Instantiate(responseWithImage) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Image");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<Image>().preserveAspect = true;
        responsetext.GetComponent<Image>().sprite = image;
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        responsego.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintFirstResponseWithAffinity(Sprite avatar, bool isPositve) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        GameObject responsego = Instantiate(responseWithAffinity) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsekind = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Kind");
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Image");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<Image>().preserveAspect = true;
        responsetext.GetComponent<Image>().sprite = heart;
        if (isPositve) {
            responsekind.GetComponent<TMP_Text>().text = "+";
            responsetext.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        } else {
            responsekind.GetComponent<TMP_Text>().text = "-";
            responsetext.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
        }
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        responsego.SetActive(true);
        messageSound.Play();
        if (isPositve) {
            LeanTween.color(responsetext.gameObject.GetComponent<RectTransform>(), new Color32(187, 69, 135, 255), 2f);
            LeanTween.scale(responsetext.gameObject.GetComponent<RectTransform>(), responsetext.gameObject.GetComponent<RectTransform>().localScale*1.2f, 1f).setEase(LeanTweenType.easeOutBounce).setLoopPingPong(3);
        } else {
            LeanTween.color(responsetext.gameObject.GetComponent<RectTransform>(), new Color32(100, 100, 100, 255), 1f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.1f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.2f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.3f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.4f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.5f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.6f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.7f);
        }
        if (PlayerPrefs.GetInt("firstAffinity", 1) == 1) {
            PlayerPrefs.SetInt("firstAffinity", 0);
            affinityTooltipgo = Instantiate(affinityTooltip) as GameObject;
            affinityTooltipgo.transform.parent = responsego.transform;
            GameObject openherego = GameObject.Find("Open here text");
            LeanTween.alpha(affinityTooltipgo.GetComponent<RectTransform>(), 1f, 1f);
            LeanTween.moveX(affinityTooltipgo, 200, 1f);
            openherego.GetComponent<TMP_Text>().LeanAlphaText(1f, 1f);
        }
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintResponseWithAffinity(Sprite avatar, bool isPositve) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return waitForSkip();
        GameObject responsego = Instantiate(responseWithAffinity) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsekind = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Kind");
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Image");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<Image>().preserveAspect = true;
        responsetext.GetComponent<Image>().sprite = heart;
        if (isPositve) {
            responsekind.GetComponent<TMP_Text>().text = "+";
            responsetext.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        } else {
            responsekind.GetComponent<TMP_Text>().text = "-";
            responsetext.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
        }
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        responsego.SetActive(true);
        messageSound.Play();
        if (isPositve) {
            LeanTween.color(responsetext.gameObject.GetComponent<RectTransform>(), new Color32(187, 69, 135, 255), 2f);
            LeanTween.scale(responsetext.gameObject.GetComponent<RectTransform>(), responsetext.gameObject.GetComponent<RectTransform>().localScale*1.2f, 1f).setEase(LeanTweenType.easeOutBounce).setLoopPingPong(3);
        } else {
            LeanTween.color(responsetext.gameObject.GetComponent<RectTransform>(), new Color32(100, 100, 100, 255), 1f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.1f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.2f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.3f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.4f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.5f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.6f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.7f);
        }
        if (PlayerPrefs.GetInt("firstAffinity", 1) == 1) {
            PlayerPrefs.SetInt("firstAffinity", 0);
            affinityTooltipgo = Instantiate(affinityTooltip) as GameObject;
            affinityTooltipgo.transform.parent = responsego.transform;
            GameObject openherego = GameObject.Find("Open here text");
            LeanTween.alpha(affinityTooltipgo.GetComponent<RectTransform>(), 1f, 1f);
            LeanTween.moveX(affinityTooltipgo, 200, 1f);
            openherego.GetComponent<TMP_Text>().LeanAlphaText(1f, 1f);
        }
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintSlowResponseWithAffinity(Sprite avatar, bool isPositve) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return slowWaitForSkip();
        GameObject responsego = Instantiate(responseWithAffinity) as GameObject;
        responsego.SetActive(false);
        responsego.transform.parent = GameObject.Find("Content").transform;
        Transform responsekind = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Kind");
        Transform responsetext = responsego.transform.Find("Textbox container/Textbox inner container/Player text/Image");
        Transform responsename = responsego.transform.Find("Textbox container/Textbox inner container/Character name");
        Transform responseavatar = responsego.transform.Find("Circular mask/Character image");
        responsetext.GetComponent<Image>().preserveAspect = true;
        responsetext.GetComponent<Image>().sprite = heart;
        if (isPositve) {
            responsekind.GetComponent<TMP_Text>().text = "+";
            responsetext.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        } else {
            responsekind.GetComponent<TMP_Text>().text = "-";
            responsetext.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
        }
        responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][avatar.name];
        responsename.GetComponent<TMP_Text>().color = avatarColors[avatar.name];
        if (avatar) {
            responseavatar.GetComponent<Image>().sprite = avatar;
        }
        yield return ScrollDown();
        responsego.SetActive(true);
        messageSound.Play();
        if (isPositve) {
            LeanTween.color(responsetext.gameObject.GetComponent<RectTransform>(), new Color32(187, 69, 135, 255), 2f);
            LeanTween.scale(responsetext.gameObject.GetComponent<RectTransform>(), responsetext.gameObject.GetComponent<RectTransform>().localScale*1.2f, 1f).setEase(LeanTweenType.easeOutBounce).setLoopPingPong(3);
        } else {
            LeanTween.color(responsetext.gameObject.GetComponent<RectTransform>(), new Color32(100, 100, 100, 255), 1f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.1f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.2f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.3f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.4f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.5f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), 2f, 0.05f).setLoopPingPong(1).setDelay(0.6f);
            LeanTween.moveX(responsetext.gameObject.GetComponent<RectTransform>(), -2f, 0.05f).setLoopPingPong(1).setDelay(0.7f);
        }
        if (PlayerPrefs.GetInt("firstAffinity", 1) == 1) {
            PlayerPrefs.SetInt("firstAffinity", 0);
            affinityTooltipgo = Instantiate(affinityTooltip) as GameObject;
            affinityTooltipgo.transform.parent = responsego.transform;
            GameObject openherego = GameObject.Find("Open here text");
            LeanTween.alpha(affinityTooltipgo.GetComponent<RectTransform>(), 1f, 1f);
            LeanTween.moveX(affinityTooltipgo, 200, 1f);
            openherego.GetComponent<TMP_Text>().LeanAlphaText(1f, 1f);
        }
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintFirstNarrator(string narratorString) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        GameObject narratorgo = Instantiate(narrator) as GameObject;
        narratorgo.SetActive(false);
        narratorgo.transform.parent = GameObject.Find("Content").transform;
        Transform narratortext = narratorgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext.GetComponent<TextLocalizer>().id = narratorString;
        narratortext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(narratorString);
        yield return ScrollDown();
        narratorgo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintNarrator(string narratorString) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return waitForSkip();
        GameObject narratorgo = Instantiate(narrator) as GameObject;
        narratorgo.SetActive(false);
        narratorgo.transform.parent = GameObject.Find("Content").transform;
        Transform narratortext = narratorgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext.GetComponent<TextLocalizer>().id = narratorString;
        narratortext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(narratorString);
        yield return ScrollDown();
        narratorgo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintSlowNarrator(string narratorString) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return slowWaitForSkip();
        GameObject narratorgo = Instantiate(narrator) as GameObject;
        narratorgo.SetActive(false);
        narratorgo.transform.parent = GameObject.Find("Content").transform;
        Transform narratortext = narratorgo.transform.Find("Textbox container/Narrator text/Text (TMP)");
        narratortext.GetComponent<TextLocalizer>().id = narratorString;
        narratortext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(narratorString);
        yield return ScrollDown();
        narratorgo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintFirstNarratorWithImage(Sprite image) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        GameObject narratorgo = Instantiate(narratorWithImage) as GameObject;
        narratorgo.SetActive(false);
        narratorgo.transform.parent = GameObject.Find("Content").transform;
        Transform narratortext = narratorgo.transform.Find("Textbox container/Narrator text/Image");
        narratortext.GetComponent<Image>().preserveAspect = true;
        narratortext.GetComponent<Image>().sprite = image;
        yield return ScrollDown();
        narratorgo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintNarratorWithImage(Sprite image) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return waitForSkip();
        GameObject narratorgo = Instantiate(narratorWithImage) as GameObject;
        narratorgo.SetActive(false);
        narratorgo.transform.parent = GameObject.Find("Content").transform;
        Transform narratortext = narratorgo.transform.Find("Textbox container/Narrator text/Image");
        narratortext.GetComponent<Image>().preserveAspect = true;
        narratortext.GetComponent<Image>().sprite = image;
        yield return ScrollDown();
        narratorgo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public IEnumerator PaintSlowNarratorWithImage(Sprite image) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        yield return slowWaitForSkip();
        GameObject narratorgo = Instantiate(narratorWithImage) as GameObject;
        narratorgo.SetActive(false);
        narratorgo.transform.parent = GameObject.Find("Content").transform;
        Transform narratortext = narratorgo.transform.Find("Textbox container/Narrator text/Image");
        narratortext.GetComponent<Image>().preserveAspect = true;
        narratortext.GetComponent<Image>().sprite = image;
        yield return ScrollDown();
        narratorgo.SetActive(true);
        messageSound.Play();
        yield return ScrollDown();
        yield return ScrollDown();
    }
    public void ChangeReply(string optionA, string optionB) {
        Transform textA = transform.Find("Text (TMP)");
        textA.GetComponent<TextLocalizer>().id = optionA;
        textA.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(optionA);
        secondReplyOption.SetActive(true);
        Transform textB = transform.parent.transform.Find("Reply option (1)/Text (TMP)");
        textB.GetComponent<TextLocalizer>().id = optionB;
        textB.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(optionB);
        thirdReplyOption.SetActive(false);
    }
    public void ChangeReplyWithOneOption(string optionA) {
        Transform textA = transform.Find("Text (TMP)");
        textA.GetComponent<TextLocalizer>().id = optionA;
        textA.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(optionA);
        secondReplyOption.SetActive(false);
        thirdReplyOption.SetActive(false);
    }
    public void ChangeReplyWithThreeOptions(string optionA, string optionB, string optionC) {
        Transform textA = transform.Find("Text (TMP)");
        textA.GetComponent<TextLocalizer>().id = optionA;
        textA.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(optionA);
        secondReplyOption.SetActive(true);
        Transform textB = transform.parent.transform.Find("Reply option (1)/Text (TMP)");
        textB.GetComponent<TextLocalizer>().id = optionB;
        textB.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(optionB);
        thirdReplyOption.SetActive(true);
        Transform textC = transform.parent.transform.Find("Reply option (2)/Text (TMP)");
        textC.GetComponent<TextLocalizer>().id = optionC;
        textC.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(optionC);
    }
    IEnumerator ScrollDown() {
        LayoutRebuilder.ForceRebuildLayoutImmediate(GameObject.Find("Content").GetComponent<RectTransform>());
        if(!blockScrolling) {
            yield return new WaitForEndOfFrame();
            scrollrect.verticalNormalizedPosition = 0;
            LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)scrollrect.transform);
        } else {
            yield return null;
        }
    }
    public void ActivateSelection() {
        selectionPossible = true;
        RectTransform glow = GameObject.Find("Select button focus").GetComponent<RectTransform>();
        LeanTween.alpha(glow, 1f, 0.4f).setDelay(3f).setLoopPingPong(-1);
        LeanTween.color(GameObject.Find("Select button").GetComponent<RectTransform>(), new Color32(72, 19, 106, 255), 0.4f).setDelay(3f).setLoopPingPong(-1);
        GameObject.Find("Bottom bar").GetComponent<Button>().onClick.AddListener(() => CancelTween(GameObject.Find("Select button focus")));
        GameObject.Find("Select button").GetComponent<Button>().onClick.AddListener(() => CancelTween(GameObject.Find("Select button focus")));
    }
    void CancelTween(GameObject go) {
        LeanTween.cancel(go);
        LeanTween.cancel(GameObject.Find("Select button"));
        Image image = go.GetComponent<Image>();
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0f);
        Image image2 = GameObject.Find("Select button").GetComponent<Image>();
        image2.color = new Color(1f, 1f, 1f, 1f);
    }
    private IEnumerator waitForSkip() {
        yield return ScrollDown();
        bool done = false;
        float continueTime = Time.time + 4f;
        while(!done && (Time.time < continueTime)) {
            if(sceneOverlap) {
                continueTime = Time.time + 4f;
            }
            // if(EventSystem.current.currentSelectedGameObject!=null && EventSystem.current.currentSelectedGameObject.name!="Image" && EventSystem.current.currentSelectedGameObject.name!="Back button" && EventSystem.current.currentSelectedGameObject.name!="Circular mask" && EventSystem.current.currentSelectedGameObject.name!="Theme" && !ImageClick.zoomed && !avatarClicked && timeAfterTap <15f && Input.GetMouseButtonUp(0) && !(SceneManager.GetSceneByName("IshakProfile").isLoaded || SceneManager.GetSceneByName("PlayerProfile").isLoaded)) {
            //     done = true;
            // }
            if(EventSystem.current.currentSelectedGameObject!=null && EventSystem.current.currentSelectedGameObject.name=="Hourglass button" && Input.GetMouseButtonUp(0)) {
                done = true;
            }
            yield return null;
        }
    }
    private IEnumerator slowWaitForSkip() {
        yield return ScrollDown();
        bool done = false;
        float continueTime = Time.time + 5.5f;
        while(!done && (Time.time < continueTime)) {
            if(sceneOverlap) {
                continueTime = Time.time + 5.5f;
            }
            // if(EventSystem.current.currentSelectedGameObject!=null && EventSystem.current.currentSelectedGameObject.name!="Image" && EventSystem.current.currentSelectedGameObject.name!="Back button" && EventSystem.current.currentSelectedGameObject.name!="Circular mask" && EventSystem.current.currentSelectedGameObject.name!="Theme" && !ImageClick.zoomed && !avatarClicked && timeAfterTap < 15f && Input.GetMouseButtonUp(0) && !(SceneManager.GetSceneByName("IshakProfile").isLoaded || SceneManager.GetSceneByName("PlayerProfile").isLoaded)) {
            //     done = true;
            // }
            if(EventSystem.current.currentSelectedGameObject!=null && EventSystem.current.currentSelectedGameObject.name=="Hourglass button" && Input.GetMouseButtonUp(0)) {
                done = true;
            }
            yield return null;
        }
    }
    private IEnumerator waitForAnimationFinished() {
        bool done = false;
        while(!done) {
            if(GameObject.Find("Main Panel").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1) {
                done = true;
            }
            yield return null;
        }
    }
    private IEnumerator waitForSceneClosing() {
        bool done = false;
        while(!done) {
            if(!sceneOverlap) {
                done = true;
            }
            yield return null;
        }
    }
    public void SetAffinity(string name, int diff) {
        if (name == "grandpa") {
            grandpaAffinity = Mathf.Clamp(grandpaAffinity+diff, 1, 10);
            PlayerPrefs.SetInt("grandpaAffinity", grandpaAffinity);
        }
        else if (name == "grandma" || name == "grandma70") {
            grandmaAffinity = Mathf.Clamp(grandmaAffinity+diff, 1, 10);
            PlayerPrefs.SetInt("grandmaAffinity", grandmaAffinity);
        }
        else if (name == "dad") {
            dadAffinity = Mathf.Clamp(dadAffinity+diff, 1, 10);
            PlayerPrefs.SetInt("dadAffinity", dadAffinity);
        }
        else if (name == "mom") {
            mumAffinity = Mathf.Clamp(mumAffinity+diff, 1, 10);
            PlayerPrefs.SetInt("mumAffinity", mumAffinity);
        }
        else if (name == "nicholas") {
            nicAffinity = Mathf.Clamp(nicAffinity+diff, 1, 10);
            PlayerPrefs.SetInt("nicAffinity", nicAffinity);
        }
        else if (name == "tommy") {
            tommyAffinity = Mathf.Clamp(tommyAffinity+diff, 1, 10);
            PlayerPrefs.SetInt("tommyAffinity", tommyAffinity);
        }
        else if (name == "dave") {
            daveAffinity = Mathf.Clamp(daveAffinity+diff, 1, 10);
            PlayerPrefs.SetInt("daveAffinity", daveAffinity);
        }
        PlayerPrefs.SetInt("newAffinity", 1);
    }
    public void UnlockAnImage(Sprite image) {
        if (!PlayerPrefs.GetString("images").Contains(image.name)) {
            UnlockImage.images.Add(image);
            if (PlayerPrefs.GetString("images") == "") {
                PlayerPrefs.SetString("images", image.name);
            } else {
                PlayerPrefs.SetString("images", PlayerPrefs.GetString("images")+"|"+image.name);
            }
            PlayerPrefs.SetInt("newImage", 1);
        }
    }
    public void UnlockAnAchievement(Sprite image) {
        if (!PlayerPrefs.GetString("achievements").Contains(image.name)) {
            if (PlayerPrefs.GetString("achievements") == "") {
                PlayerPrefs.SetString("achievements", image.name);
            } else {
                PlayerPrefs.SetString("achievements", PlayerPrefs.GetString("achievements")+"|"+image.name);
            }
            PlayerPrefs.SetInt("newAchievements", 1);
            GameObject confettigo = Instantiate(confetti) as GameObject;
            confettigo.transform.parent = GameObject.Find("Main Panel").transform;
            confettigo.GetComponent<RectTransform>().anchoredPosition = new Vector3(-80f, -35f, 0f);
            confettigo.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = image;
            LeanTween.scale(confettigo.GetComponent<RectTransform>(), new Vector3(1f, 1f, 1f), 0.5f);
            achievementSound.Play();
            LeanTween.scale(confettigo.GetComponent<RectTransform>(), new Vector3(1.2f, 1.2f, 1.2f), 0.2f).setDelay(0.5f).setEase(LeanTweenType.easeOutBounce).setLoopPingPong(1);
            LeanTween.scale(confettigo.GetComponent<RectTransform>(), new Vector3(0f, 0f, 0f), 0.5f).setDelay(5f);
            Destroy(confettigo, 5.5f);
        }
    }
    public void ChooseChoice(int index) {
        StartCoroutine(ChooseChoiceEnumerator(index));
    }
    public IEnumerator ChooseChoiceEnumerator(int index) {
        if (prologueStory.currentChoices[0].text == "Continue to Chapter 8") {
            // string language = PlayerPrefs.GetString("Language", "English");
            // PlayerPrefs.DeleteAll();
            // SaveGameManager.Instance.SaveableObjects = new List<SaveableObject>();
            // PlayerPrefs.SetString("Language", language);
            // PlayerPrefs.SetString("images", "");
            // PlayerPrefs.SetString("achievements", "");
            // PlayerPrefs.SetInt("newAchievements", 0);
            // PlayerPrefs.SetInt("newAffinity", 0);
            // grandpaAffinity = 6;
            // PlayerPrefs.SetInt("grandpaAffinity", grandpaAffinity);
            // grandmaAffinity = 8;
            // PlayerPrefs.SetInt("grandmaAffinity", grandmaAffinity);
            // dadAffinity = 5;
            // PlayerPrefs.SetInt("dadAffinity", dadAffinity);
            // mumAffinity = 4;
            // PlayerPrefs.SetInt("mumAffinity", mumAffinity);
            // nicAffinity = 4;
            // PlayerPrefs.SetInt("nicAffinity", nicAffinity);
            // tommyAffinity = 4;
            // PlayerPrefs.SetInt("nicAffinity", tommyAffinity);
            // prologueStory.ResetState();
            // foreach(Transform child in GameObject.Find("Content").transform)
            // {
            //     Destroy(child.gameObject);
            // }
            PlayerPrefs.SetString("sceneToPlay", "Chapter8");
            if (PlayerPrefs.GetString("memory") == "You chose the twins' birth memory") {
                PlayerPrefs.SetString("date", "date8_twinsbirth");
                PlayerPrefs.SetString("time", "time8_twinsbirth");
            } else if (PlayerPrefs.GetString("memory") == "You chose the Christmas memory") {
                PlayerPrefs.SetString("date", "date8_christmas");
                PlayerPrefs.SetString("time", "time8_christmas");
            } 
            fade.SetActive(true);
            LeanTween.alpha(fade.GetComponent<RectTransform>(), 1f, 1f);
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene("Ending7",LoadSceneMode.Additive);
        } else {
            prologueStory.ChooseChoiceIndex(index);
            PlayerPrefs.SetString("memory", (string)prologueStory.variablesState["memory"]);
            Scene[] scenes = SceneManager.GetAllScenes();
            foreach (Scene sc in scenes) {
                if (sc.name == "Ishak") {
                    PlayerPrefs.SetString("inkSaveState0", prologueStory.state.ToJson());
                }
                if (sc.name == "Chapter1") {
                    PlayerPrefs.SetString("inkSaveState1", prologueStory.state.ToJson());
                }
                if (sc.name == "Chapter2") {
                    PlayerPrefs.SetString("inkSaveState2", prologueStory.state.ToJson());
                }
                if (sc.name == "Chapter3") {
                    PlayerPrefs.SetString("inkSaveState3", prologueStory.state.ToJson());
                }
                if (sc.name == "Chapter4") {
                    PlayerPrefs.SetString("inkSaveState4", prologueStory.state.ToJson());
                }
                if (sc.name == "Chapter5") {
                    PlayerPrefs.SetString("inkSaveState5", prologueStory.state.ToJson());
                }
                if (sc.name == "Chapter6") {
                    PlayerPrefs.SetString("inkSaveState6", prologueStory.state.ToJson());
                }
                if (sc.name == "Chapter7") {
                    PlayerPrefs.SetString("inkSaveState7", prologueStory.state.ToJson());
                }
                if (sc.name == "Chapter8") {
                    PlayerPrefs.SetString("inkSaveState8", prologueStory.state.ToJson());
                }
                if (sc.name == "Chapter9") {
                    PlayerPrefs.SetString("inkSaveState9", prologueStory.state.ToJson());
                }
            }
            yield return null;
        }
        StartCoroutine(LoadStoryChunk());
    }
    IEnumerator LoadStoryChunk() {
        Scene[] scenes = SceneManager.GetAllScenes();
        foreach (Scene sc in scenes) {
            if (sc.name == "Ishak") {
                if (PlayerPrefs.HasKey("inkSaveState0")) {
                    prologueStory.state.LoadJson(PlayerPrefs.GetString("inkSaveState0"));
                }
            }
            if (sc.name == "Chapter1") {
                if (PlayerPrefs.HasKey("inkSaveState1")) {
                    prologueStory.state.LoadJson(PlayerPrefs.GetString("inkSaveState1"));
                }
            }
            if (sc.name == "Chapter2") {
                if (PlayerPrefs.HasKey("inkSaveState2")) {
                    prologueStory.state.LoadJson(PlayerPrefs.GetString("inkSaveState2"));
                }
            }
            if (sc.name == "Chapter3") {
                if (PlayerPrefs.HasKey("inkSaveState3")) {
                    prologueStory.state.LoadJson(PlayerPrefs.GetString("inkSaveState3"));
                }
            }
            if (sc.name == "Chapter4") {
                if (PlayerPrefs.HasKey("inkSaveState4")) {
                    prologueStory.state.LoadJson(PlayerPrefs.GetString("inkSaveState4"));
                }
            }
            if (sc.name == "Chapter5") {
                if (PlayerPrefs.HasKey("inkSaveState5")) {
                    prologueStory.state.LoadJson(PlayerPrefs.GetString("inkSaveState5"));
                }
            }
            if (sc.name == "Chapter6") {
                if (PlayerPrefs.HasKey("inkSaveState6")) {
                    prologueStory.state.LoadJson(PlayerPrefs.GetString("inkSaveState6"));
                }
            }
            if (sc.name == "Chapter7") {
                if (PlayerPrefs.HasKey("inkSaveState7")) {
                    prologueStory.state.LoadJson(PlayerPrefs.GetString("inkSaveState7"));
                }
            }
            if (sc.name == "Chapter8") {
                if (PlayerPrefs.HasKey("inkSaveState8")) {
                    prologueStory.state.LoadJson(PlayerPrefs.GetString("inkSaveState8"));
                }
            }
            if (sc.name == "Chapter9") {
                if (PlayerPrefs.HasKey("inkSaveState9")) {
                    prologueStory.state.LoadJson(PlayerPrefs.GetString("inkSaveState9"));
                }
            }
        }
        while (prologueStory.canContinue) {
            yield return waitForSceneClosing();
            string textToSay = prologueStory.Continue();
            textToSay = textToSay.Substring(0, textToSay.Length - 1);
            List<string> tags = prologueStory.currentTags;
            Sprite who = Resources.Load<Sprite>("Images/Avatar/bea_avatarQ");
            if (tags.Count > 0) {
                if (tags[0] == "grandpa") {
                    who = Resources.Load<Sprite>("Images/Avatar/nonno_avatarQ");
                } else if (tags[0] == "grandma") {
                    who = Resources.Load<Sprite>("Images/Avatar/nonna2_avatarQ");
                } else if (tags[0] == "grandma70") {
                    who = Resources.Load<Sprite>("Images/Avatar/nonna70_avatarQ");
                } else if (tags[0] == "dad") {
                    who = Resources.Load<Sprite>("Images/Avatar/papà_avatarQ");
                } else if (tags[0] == "mom") {
                    who = Resources.Load<Sprite>("Images/Avatar/mamma_avatarQ");
                } else if (tags[0] == "nicholas") {
                    who = Resources.Load<Sprite>("Images/Avatar/nicholas_avatarQ");
                } else if (tags[0] == "tommy") {
                    who = Resources.Load<Sprite>("Images/Avatar/tommy_avatarQ");
                } else if (tags[0] == "dave") {
                    who = Resources.Load<Sprite>("Images/Avatar/dave_avatarQ");
                } else if (tags[0] == "beatrice" || tags[0] == "beatricevoiceover") {
                    who = Resources.Load<Sprite>("Images/Avatar/bea_avatarQ");
                } else if (tags[0] == "secretary") {
                    who = Resources.Load<Sprite>("Images/Avatar/segretaria_avatarQ");
                } else if (tags[0] == "pastbeatrice") {
                    who = Resources.Load<Sprite>("Images/Avatar/pastbea_avatarQ");
                } else if (tags[0] == "recruiter") {
                    who = Resources.Load<Sprite>("Images/Avatar/recruiter_avatarQ");
                }

                if (tags.Count > 1) {
                    if (tags[1] == "first") {
                        if (tags[0] == "narrator") {
                            yield return PaintFirstNarrator(textToSay);
                        } else if (tags[0] == "narratorwithimage") {
                            yield return PaintFirstNarratorWithImage(Resources.Load<Sprite>("Images/Gallery/"+textToSay));
                            UnlockAnImage(Resources.Load<Sprite>("Images/Gallery/"+textToSay));
                        } else if (tags[0] == "beatrice") {
                            yield return PaintFirstReply(textToSay, who);
                        } else if (tags[0] == "beatricevoiceover") {
                            yield return PaintFirstReplyVoiceover(textToSay, who);
                        } else {
                            yield return PaintFirstResponse(textToSay, who);
                        }
                    } else if (tags[1] == "slow") {
                        if (tags[0] == "narrator") {
                            yield return PaintSlowNarrator(textToSay);
                        } else if (tags[0] == "beatrice") {
                            yield return PaintSlowReply(textToSay, who);
                        } else if (tags[0] == "beatricevoiceover") {
                            yield return PaintSlowReplyVoiceover(textToSay, who);
                        } else if (tags[0] == "narratorwithimage") {
                            yield return PaintSlowNarratorWithImage(Resources.Load<Sprite>("Images/Gallery/"+textToSay));
                            UnlockAnImage(Resources.Load<Sprite>("Images/Gallery/"+textToSay));
                        } else {
                            yield return PaintSlowResponse(textToSay, who);
                        }
                    } else if (tags[1] == "affinity") {
                        yield return PaintResponseWithAffinity(who, int.Parse(textToSay)>0);
                        SetAffinity(tags[0], int.Parse(textToSay));
                    } else if(tags[1] == "firstaffinity") {
                        yield return PaintFirstResponseWithAffinity(who, int.Parse(textToSay)>0);
                        SetAffinity(tags[0], int.Parse(textToSay));
                    } else if (tags[1] == "slowaffinity") {
                        yield return PaintSlowResponseWithAffinity(who, int.Parse(textToSay)>0);
                        SetAffinity(tags[0], int.Parse(textToSay));
                    }
                } else {
                    if (tags[0] == "narratorwithimage") {
                        yield return PaintNarratorWithImage(Resources.Load<Sprite>("Images/Gallery/"+textToSay));
                        UnlockAnImage(Resources.Load<Sprite>("Images/Gallery/"+textToSay));
                    } else if (tags[0] == "narrator") {
                        yield return PaintNarrator(textToSay);
                    } else if (tags[0] == "beatrice") {
                        yield return PaintReply(textToSay, who);
                    } else if (tags[0] == "beatricevoiceover") {
                        yield return PaintReplyVoiceover(textToSay, who);
                    } else if (tags[0] == "achievement") {
                        UnlockAnAchievement(Resources.Load<Sprite>("Images/Badges/"+textToSay));
                    } else {
                        yield return PaintResponse(textToSay, who);
                    }
                }
                yield return ScrollDown();
                foreach (Scene sc in scenes) {
                    if (sc.name == "Ishak") {
                        PlayerPrefs.SetString("inkSaveState0", prologueStory.state.ToJson());
                    }
                    if (sc.name == "Chapter1") {
                        PlayerPrefs.SetString("inkSaveState1", prologueStory.state.ToJson());
                    }
                    if (sc.name == "Chapter2") {
                        PlayerPrefs.SetString("inkSaveState2", prologueStory.state.ToJson());
                    }
                    if (sc.name == "Chapter3") {
                        PlayerPrefs.SetString("inkSaveState3", prologueStory.state.ToJson());
                    }
                    if (sc.name == "Chapter4") {
                        PlayerPrefs.SetString("inkSaveState4", prologueStory.state.ToJson());
                    }
                    if (sc.name == "Chapter5") {
                        PlayerPrefs.SetString("inkSaveState5", prologueStory.state.ToJson());
                    }
                    if (sc.name == "Chapter6") {
                        PlayerPrefs.SetString("inkSaveState6", prologueStory.state.ToJson());
                    }
                    if (sc.name == "Chapter7") {
                        PlayerPrefs.SetString("inkSaveState7", prologueStory.state.ToJson());
                    }
                    if (sc.name == "Chapter8") {
                        PlayerPrefs.SetString("inkSaveState8", prologueStory.state.ToJson());
                    }
                    if (sc.name == "Chapter9") {
                        PlayerPrefs.SetString("inkSaveState9", prologueStory.state.ToJson());
                    }
                }
            }
            PlayerPrefs.SetString("memory", (string)prologueStory.variablesState["memory"]);
        }
        if (prologueStory.currentChoices.Count == 2) {
            ChangeReply(prologueStory.currentChoices[0].text, prologueStory.currentChoices[1].text);
        } else if (prologueStory.currentChoices.Count == 1) {
            ChangeReplyWithOneOption(prologueStory.currentChoices[0].text);
        } else if (prologueStory.currentChoices.Count == 3) {
            ChangeReplyWithThreeOptions(prologueStory.currentChoices[0].text, prologueStory.currentChoices[1].text, prologueStory.currentChoices[2].text);
        }
        ActivateSelection();
    }
}