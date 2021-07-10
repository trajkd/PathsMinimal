using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class SaveGameManager : MonoBehaviour
{
    private static SaveGameManager instance;
    public List<SaveableObject> SaveableObjects {get; set;}
    public static SaveGameManager Instance {
        get {
            if (instance == null) {
                instance = GameObject.FindObjectOfType<SaveGameManager>();
            }
            return instance;
        }
    }
    void Awake() {
        SaveableObjects = new List<SaveableObject>();
    }
    //Save
    void OnDisable() {
        Scene[] scenes = SceneManager.GetAllScenes();
        string[] scenesStrings = new string[scenes.Count()];
        int index = 0;
        foreach (Scene sc in scenes) {
            scenesStrings[index] = sc.name;
            index++;
        }
        if (scenesStrings.Contains("Ishak")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Ishak", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter1")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter1", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter2")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter2", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter3")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter3", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter4")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter4", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter5")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter5", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter6")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter6", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter7")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter7", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter8")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter8", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter9")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter9", SaveableObjects.Count);
        }
        for (int i = 0; i < SaveableObjects.Count; i++) {
            SaveableObjects[i].Save(i);
        }
    }
    void OnApplicationPause() {
        Scene[] scenes = SceneManager.GetAllScenes();
        string[] scenesStrings = new string[scenes.Count()];
        int index = 0;
        foreach (Scene sc in scenes) {
            scenesStrings[index] = sc.name;
            index++;
        }
        if (scenesStrings.Contains("Ishak")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Ishak", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter1")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter1", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter2")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter2", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter3")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter3", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter4")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter4", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter5")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter5", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter6")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter6", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter7")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter7", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter8")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter8", SaveableObjects.Count);
        } else if (scenesStrings.Contains("Chapter9")) {
            PlayerPrefs.SetInt("ObjectCount"+"_"+"Chapter9", SaveableObjects.Count);
        }
        for (int i = 0; i < SaveableObjects.Count; i++) {
            SaveableObjects[i].Save(i);
        }
    }
    //Load
    void OnEnable() {
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
        int objectCount = PlayerPrefs.GetInt("ObjectCount"+"_"+activeChapter);
        for (int i = 0; i < objectCount; i++) {
            string[] value = PlayerPrefs.GetString(i.ToString()+"_"+activeChapter).Split('|');
            GameObject tmp = null;
            switch (value[0]) {
                case "CharacterImageMessage":
                    tmp = Instantiate(Resources.Load("Character image message") as GameObject);
                    break;
                case "CharacterMessage":
                    tmp = Instantiate(Resources.Load("Character message") as GameObject);
                    break;
                case "NarratorImageMessage":
                    tmp = Instantiate(Resources.Load("Narrator image message") as GameObject);
                    break;
                case "NarratorMessage":
                    tmp = Instantiate(Resources.Load("Narrator message") as GameObject);
                    break;
                case "PlayerMessage":
                    tmp = Instantiate(Resources.Load("Player message") as GameObject);
                    break;
                case "PlayerVoiceoverMessage":
                    tmp = Instantiate(Resources.Load("Player voiceover message") as GameObject);
                    break;
                case "CharacterAffinityMessage":
                    tmp = Instantiate(Resources.Load("Character affinity message") as GameObject);
                    break;
            }
            if (tmp != null) {
                tmp.GetComponent<SaveableObject>().Load(value);
            }
        }
    }
}
