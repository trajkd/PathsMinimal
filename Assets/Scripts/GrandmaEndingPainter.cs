using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Ink.Runtime;
using UnityEngine.EventSystems;

public class GrandmaEndingPainter : MonoBehaviour
{
    [SerializeField]GameObject reply;
    [SerializeField]GameObject replyVoiceover;
    [SerializeField]GameObject response;
    [SerializeField]GameObject responseWithImage;
    [SerializeField]GameObject narrator;
    [SerializeField]GameObject narratorWithImage;
    [SerializeField]GameObject secondReplyOption;
    [SerializeField]GameObject thirdReplyOption;
    [SerializeField]GameObject fade;
    [SerializeField]GameObject blackFade;
    [SerializeField]AudioSource messageSound;
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
        scrollrect = GameObject.Find("Scroll View 10").GetComponent<ScrollRect>();
        LeanTween.alpha(blackFade.GetComponent<RectTransform>(), 0f, 1f);
        yield return new WaitForSeconds(1f);
        blackFade.SetActive(false);
        if (PlayerPrefs.GetInt("grandma_dead") == 0) {
            yield return PaintFirstNarrator("Grandma and Beatrice are sitting on the couch in the living room, where everything started. They are talking about Beatrice's travels.");
            yield return ScrollDown();
            yield return PaintSlowResponse("I'm so proud of you.", Resources.Load<Sprite>("Images/Avatar/nonna2_avatarQ"));
            yield return ScrollDown();
            yield return PaintReply("All through this adventure, I've had so many doubts about my ability to fix everything, but you were right, Grandma.", Resources.Load<Sprite>("Images/Avatar/bea_avatarQ"));
            yield return ScrollDown();
            yield return PaintSlowReply("I've always had it in me, I just had to learn to take other people's feeling into account and not just mine.", Resources.Load<Sprite>("Images/Avatar/bea_avatarQ"));
            yield return ScrollDown();
            yield return PaintSlowReply("The path I chose to follow allows me to be stonger, because I've understood how to show my love and how to let other people love me. Things could have gone a lot differently if I had made different choices, but I followed my heart and I don't regret any decision.", Resources.Load<Sprite>("Images/Avatar/bea_avatarQ"));
            yield return ScrollDown();
            yield return PaintSlowReply("I'll keep on walking on this path, I swear.", Resources.Load<Sprite>("Images/Avatar/bea_avatarQ"));
            yield return ScrollDown();
            yield return PaintNarrator("Grandma and Beatrice hug. As they do, Nicholas and Tommy enter the room. Immediately, they run towards them and join the hug.");
            yield return ScrollDown();
            yield return PaintSlowNarratorWithImage(Resources.Load<Sprite>("Images/Gallery/"+"cap8-5"));
            UnlockAnImage(Resources.Load<Sprite>("Images/Gallery/"+"cap8-5"));
            yield return ScrollDown();
        } else {
            yield return PaintFirstNarrator("Beatrice is standing in front of Grandma's grave. She misses her, but she is smiling. She's serene now. She kneels and places a letter and a bouquet of lilies on the grave.");
            yield return ScrollDown();
            yield return PaintSlowNarratorWithImage(Resources.Load<Sprite>("Images/Gallery/"+"cap8-6"));
            UnlockAnImage(Resources.Load<Sprite>("Images/Gallery/"+"cap8-6"));
            yield return ScrollDown();
            yield return PaintReply("I think you'd be proud of me.", Resources.Load<Sprite>("Images/Avatar/bea_avatarQ"));
            yield return ScrollDown();
            yield return PaintReply("All through this adventure, I've had so many doubts about my ability to fix everything, but you were right.", Resources.Load<Sprite>("Images/Avatar/bea_avatarQ"));
            yield return ScrollDown();
            yield return PaintSlowReply("I've always had it in me, I just had to learn to take other people's feeling into account and not just mine.", Resources.Load<Sprite>("Images/Avatar/bea_avatarQ"));
            yield return ScrollDown();
            yield return PaintSlowReply("The path I chose to follow allows me to be stonger, because I've understood how to show my love and how to let other people love me.", Resources.Load<Sprite>("Images/Avatar/bea_avatarQ"));
            yield return ScrollDown();
            yield return PaintSlowReply("Things could have gone a lot differently if I had made different choices, but I followed my heart and I don't regret any decision. I'll keep on walking on this path, I swear.", Resources.Load<Sprite>("Images/Avatar/bea_avatarQ"));
            yield return ScrollDown();
            yield return PaintSlowReply("Love, Bea.", Resources.Load<Sprite>("Images/Avatar/bea_avatarQ"));
            yield return ScrollDown();
        }
        yield return new WaitForSeconds(8f);
        fade.SetActive(true);
        LeanTween.alpha(fade.GetComponent<RectTransform>(), 1f, 1f);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Ending9",LoadSceneMode.Additive);
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
        if (Input.GetMouseButton(0)) {
            if (scrollrect.verticalNormalizedPosition < 0.025) {
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
        replygo.transform.parent = GameObject.Find("ContentX").transform;
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
        replygo.transform.parent = GameObject.Find("ContentX").transform;
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
        replygo.transform.parent = GameObject.Find("ContentX").transform;
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
        replygo.transform.parent = GameObject.Find("ContentX").transform;
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
        replygo.transform.parent = GameObject.Find("ContentX").transform;
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
        replygo.transform.parent = GameObject.Find("ContentX").transform;
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
        responsego.transform.parent = GameObject.Find("ContentX").transform;
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
        responsego.transform.parent = GameObject.Find("ContentX").transform;
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
        responsego.transform.parent = GameObject.Find("ContentX").transform;
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
        responsego.transform.parent = GameObject.Find("ContentX").transform;
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
        responsego.transform.parent = GameObject.Find("ContentX").transform;
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
    public IEnumerator PaintFirstNarrator(string narratorString) {
        selectionPossible = false;
        yield return waitForAnimationFinished();
        GameObject narratorgo = Instantiate(narrator) as GameObject;
        narratorgo.SetActive(false);
        narratorgo.transform.parent = GameObject.Find("ContentX").transform;
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
        narratorgo.transform.parent = GameObject.Find("ContentX").transform;
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
        narratorgo.transform.parent = GameObject.Find("ContentX").transform;
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
        narratorgo.transform.parent = GameObject.Find("ContentX").transform;
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
        narratorgo.transform.parent = GameObject.Find("ContentX").transform;
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
        narratorgo.transform.parent = GameObject.Find("ContentX").transform;
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
        LayoutRebuilder.ForceRebuildLayoutImmediate(GameObject.Find("ContentX").GetComponent<RectTransform>());
        if(!Input.GetMouseButton(0) && !blockScrolling) {
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
            if(EventSystem.current.currentSelectedGameObject!=null && EventSystem.current.currentSelectedGameObject.name!="Image" && EventSystem.current.currentSelectedGameObject.name!="Back button" && EventSystem.current.currentSelectedGameObject.name!="Circular mask" && EventSystem.current.currentSelectedGameObject.name!="Theme" && !ImageClick.zoomed && !avatarClicked && timeAfterTap <15f && Input.GetMouseButtonUp(0) && !(SceneManager.GetSceneByName("IshakProfile").isLoaded || SceneManager.GetSceneByName("PlayerProfile").isLoaded)) {
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
            if(EventSystem.current.currentSelectedGameObject!=null && EventSystem.current.currentSelectedGameObject.name!="Image" && EventSystem.current.currentSelectedGameObject.name!="Back button" && EventSystem.current.currentSelectedGameObject.name!="Circular mask" && EventSystem.current.currentSelectedGameObject.name!="Theme" && !ImageClick.zoomed && !avatarClicked && timeAfterTap < 15f && Input.GetMouseButtonUp(0) && !(SceneManager.GetSceneByName("IshakProfile").isLoaded || SceneManager.GetSceneByName("PlayerProfile").isLoaded)) {
                done = true;
            }
            yield return null;
        }
    }
    private IEnumerator waitForAnimationFinished() {
        bool done = false;
        while(!done) {
            if(GameObject.Find("Main PanelX").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1) {
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
}