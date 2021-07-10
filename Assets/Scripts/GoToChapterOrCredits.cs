using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToChapterOrCredits : MonoBehaviour
{
    public string chapterScene;
    public static bool activateFromHome = false;
    static GoToChapterOrCredits instance;
    public GameObject blockingBackground;
    GameObject bBg;
    public static GameObject blockingBg {get { return instance.bBg; } }
    public void Play() {
        instance = this;
        bBg = Instantiate(blockingBackground) as GameObject;
        bBg.transform.parent = GameObject.Find("Ending Panel").transform;
        
        if (PlayerPrefs.GetInt("last_chapter_unlocked", 0) == 1) {
            GoToChatAppFromHome.activateFromHome = true;
            SceneManager.LoadScene(chapterScene,LoadSceneMode.Additive);
        } else {
            SceneManager.LoadScene("Credits",LoadSceneMode.Additive);
        }
        StartCoroutine(unloadEnding());
    }
    IEnumerator unloadEnding() {
        Scene[] scenes = SceneManager.GetAllScenes();
        yield return new WaitForSeconds(0.66f);
        foreach (Scene sc in scenes) {
            if (sc.name == "Ending0" || sc.name == "Ending1" || sc.name == "Ending2" || sc.name == "Ending3" || sc.name == "Ending4" || sc.name == "Ending5" || sc.name == "Ending6" || sc.name == "Ending7" || sc.name == "Ending8" || sc.name == "Ending9") {
                SceneManager.UnloadScene(sc.name);
            }
        }
        if (GoToChatAppFromHome.blockingBg != null) {
            Destroy(GoToChatAppFromHome.blockingBg);
        }
    }
}