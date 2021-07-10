using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Linq;

enum ObjectType {CharacterImageMessage, CharacterMessage, CharacterAffinityMessage, NarratorImageMessage, NarratorMessage, PlayerMessage, PlayerVoiceoverMessage}
public abstract class SaveableObject : MonoBehaviour
{
    protected string save;
    [SerializeField] private ObjectType objectType;
    public static Dictionary<string, Color32> avatarColors;
    public static Dictionary<string, Dictionary<string, string>> avatarNamesTranslations;
    void Awake()
    {
        avatarColors = new Dictionary<string, Color32>();
        avatarColors.Add("nonno_avatarQ", new Color32(72, 19, 105, 255));
        avatarColors.Add("papà_avatarQ", new Color32(188, 69, 134, 255));
        avatarColors.Add("mamma_avatarQ", new Color32(83, 143, 197, 255));
        avatarColors.Add("mamma_avatarQlow", new Color32(83, 143, 197, 255));
        avatarColors.Add("nicholas_avatarQ", new Color32(83, 143, 197, 255));
        avatarColors.Add("tommy_avatarQ", new Color32(188, 69, 134, 255));
        avatarColors.Add("nonna2_avatarQ", new Color32(248, 224, 115, 255));
        avatarColors.Add("nonna70_avatarQ", new Color32(248, 224, 115, 255));
        avatarColors.Add("dave_avatarQ", new Color32(248, 224, 115, 255));
        avatarColors.Add("segretaria_avatarQ", new Color32(83, 143, 197, 255));
        avatarColors.Add("pastbea_avatarQ", new Color32(0, 0, 0, 255));
        avatarColors.Add("recruiter_avatarQ", new Color32(0, 0, 0, 255));
        avatarNamesTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["nonno_avatarQ"] = "Grandpa",
                ["nonna2_avatarQ"] = "Grandma",
                ["nonna70_avatarQ"] = "Grandma",
                ["papà_avatarQ"] = "Dad",
                ["mamma_avatarQ"] = "Mom",
                ["mamma_avatarQlow"] = "Mom",
                ["nicholas_avatarQ"] = "Nicholas",
                ["tommy_avatarQ"] = "Tommy",
                ["dave_avatarQ"] = "Dave",
                ["segretaria_avatarQ"] = "Secretary",
                ["pastbea_avatarQ"] = "Beatrice",
                ["recruiter_avatarQ"] = "Beatrice"
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["nonno_avatarQ"] = "Nonno",
                ["nonna2_avatarQ"] = "Nonna",
                ["nonna70_avatarQ"] = "Nonna",
                ["papà_avatarQ"] = "Papà",
                ["mamma_avatarQ"] = "Mamma",
                ["mamma_avatarQlow"] = "Mamma",
                ["nicholas_avatarQ"] = "Nicholas",
                ["tommy_avatarQ"] = "Tommy",
                ["dave_avatarQ"] = "Dave",
                ["segretaria_avatarQ"] = "Segretaria",
                ["pastbea_avatarQ"] = "Beatrice",
                ["recruiter_avatarQ"] = "Beatrice"
            }
        };
    }
    void Start() {
        SaveGameManager.Instance.SaveableObjects.Add(this);
    }
    public virtual void Save(int id) {
        Scene[] scenes = SceneManager.GetAllScenes();
        string[] scenesStrings = new string[scenes.Count()];
        int index = 0;
        foreach (Scene sc in scenes) {
            scenesStrings[index] = sc.name;
            index++;
        }
        string activeChapter = "";
        if (scenesStrings.Contains("Ishak")) {
            activeChapter = "Ishak";
        } else if (scenesStrings.Contains("Chapter1")) {
            activeChapter = "Chapter1";
        } else if (scenesStrings.Contains("Chapter2")) {
            activeChapter = "Chapter2";
        } else if (scenesStrings.Contains("Chapter3")) {
            activeChapter = "Chapter3";
        } else if (scenesStrings.Contains("Chapter4")) {
            activeChapter = "Chapter4";
        } else if (scenesStrings.Contains("Chapter5")) {
            activeChapter = "Chapter5";
        } else if (scenesStrings.Contains("Chapter6")) {
            activeChapter = "Chapter6";
        } else if (scenesStrings.Contains("Chapter7")) {
            activeChapter = "Chapter7";
        } else if (scenesStrings.Contains("Chapter8")) {
            activeChapter = "Chapter8";
        } else if (scenesStrings.Contains("Chapter9")) {
            activeChapter = "Chapter9";
        }
        if (objectType.ToString() == "PlayerMessage") {
            PlayerPrefs.SetString(id.ToString()+"_"+activeChapter, objectType + "|" + transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TextLocalizer>().id + "|" + transform.Find("Circular mask/Character image").GetComponent<Image>().sprite.name);
        }
        else if (objectType.ToString() == "PlayerVoiceoverMessage") {
            PlayerPrefs.SetString(id.ToString()+"_"+activeChapter, objectType + "|" + transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TextLocalizer>().id + "|" + transform.Find("Circular mask/Character image").GetComponent<Image>().sprite.name);
        }
        else if (objectType.ToString() == "CharacterMessage") {
            PlayerPrefs.SetString(id.ToString()+"_"+activeChapter, objectType + "|" + transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)").GetComponent<TextLocalizer>().id + "|" + transform.Find("Circular mask/Character image").GetComponent<Image>().sprite.name);
        }
        else if (objectType.ToString() == "CharacterImageMessage") {
            PlayerPrefs.SetString(id.ToString()+"_"+activeChapter, objectType + "|" + transform.Find("Textbox container/Textbox inner container/Player text/Image").GetComponent<Image>().sprite.name + "|" + transform.Find("Circular mask/Character image").GetComponent<Image>().sprite.name);
        }
        else if (objectType.ToString() == "CharacterAffinityMessage") {
            PlayerPrefs.SetString(id.ToString()+"_"+activeChapter, objectType + "|" + transform.Find("Textbox container/Textbox inner container/Player text/Kind").GetComponent<TMP_Text>().text + "|" + transform.Find("Circular mask/Character image").GetComponent<Image>().sprite.name);
        }
        else if (objectType.ToString() == "NarratorMessage") {
            PlayerPrefs.SetString(id.ToString()+"_"+activeChapter, objectType + "|" + transform.Find("Textbox container/Narrator text/Text (TMP)").GetComponent<TextLocalizer>().id);
        }
        else if (objectType.ToString() == "NarratorImageMessage") {
            PlayerPrefs.SetString(id.ToString()+"_"+activeChapter, objectType + "|" + transform.Find("Textbox container/Narrator text/Image").GetComponent<Image>().sprite.name);
        }
    }
    public virtual void Load(string[] values) {
        if (values[0] == "PlayerMessage") {
            transform.parent = GameObject.Find("Content").transform;
            Transform replytext = transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            Transform replyavatar = transform.Find("Circular mask/Character image");
            replytext.GetComponent<TextLocalizer>().id = values[1];
            replytext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(values[1]);
            replyavatar.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Avatar/"+values[2]);
        }
        else if (values[0] == "PlayerVoiceoverMessage") {
            transform.parent = GameObject.Find("Content").transform;
            Transform replytext = transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            Transform replyavatar = transform.Find("Circular mask/Character image");
            replytext.GetComponent<TextLocalizer>().id = values[1];
            replytext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(values[1]);
            replyavatar.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Avatar/"+values[2]);
        }
        else if (values[0] == "CharacterMessage") {
            transform.parent = GameObject.Find("Content").transform;
            Transform responsetext = transform.Find("Textbox container/Textbox inner container/Player text/Text (TMP)");
            Transform responsename = transform.Find("Textbox container/Textbox inner container/Character name");
            Transform responseavatar = transform.Find("Circular mask/Character image");
            responsetext.GetComponent<TextLocalizer>().id = values[1];
            responsetext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(values[1]);
            responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][values[2]];
            responsename.GetComponent<TMP_Text>().color = avatarColors[values[2]];
            responseavatar.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Avatar/"+values[2]);
        }
        else if (values[0] == "CharacterImageMessage") {
            transform.parent = GameObject.Find("Content").transform;
            Transform responsetext = transform.Find("Textbox container/Textbox inner container/Player text/Image");
            Transform responsename = transform.Find("Textbox container/Textbox inner container/Character name");
            Transform responseavatar = transform.Find("Circular mask/Character image");
            responsetext.GetComponent<Image>().preserveAspect = true;
            responsetext.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+values[1]);
            responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][values[2]];
            responsename.GetComponent<TMP_Text>().color = avatarColors[values[2]];
            responseavatar.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Avatar/"+values[2]);
        }
        else if (values[0] == "CharacterAffinityMessage") {
            transform.parent = GameObject.Find("Content").transform;
            Transform responsekind = transform.Find("Textbox container/Textbox inner container/Player text/Kind");
            Transform responsetext = transform.Find("Textbox container/Textbox inner container/Player text/Image");
            Transform responsename = transform.Find("Textbox container/Textbox inner container/Character name");
            Transform responseavatar = transform.Find("Circular mask/Character image");
            responsetext.GetComponent<Image>().preserveAspect = true;
            responsetext.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/cuore");
            responsekind.GetComponent<TMP_Text>().text = values[1];
            if (values[1] == "-") {
                responsetext.GetComponent<Image>().color = new Color32(100, 100, 100, 255);
            } else {
                responsetext.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            }
            responsename.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][values[2]];
            responsename.GetComponent<TMP_Text>().color = avatarColors[values[2]];
            responseavatar.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Avatar/"+values[2]);
        }
        else if (values[0] == "NarratorMessage") {
            transform.parent = GameObject.Find("Content").transform;
            Transform narratortext = transform.Find("Textbox container/Narrator text/Text (TMP)");
            narratortext.GetComponent<TextLocalizer>().id = values[1];
            narratortext.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(values[1]);
        }
        else if (values[0] == "NarratorImageMessage") {
            transform.parent = GameObject.Find("Content").transform;
            Transform narratortext = transform.Find("Textbox container/Narrator text/Image");
            narratortext.GetComponent<Image>().preserveAspect = true;
            narratortext.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+values[1]);
        }
    }
}
