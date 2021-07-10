using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToChapterAndReset : MonoBehaviour
{
    public static bool activateFromHome = false;
    static GoToChapterAndReset instance;
    public GameObject blockingBackground;
    GameObject bBg;
    public static GameObject blockingBg {get { return instance.bBg; } }
    public void Play() {
        instance = this;
        bBg = Instantiate(blockingBackground) as GameObject;
        bBg.transform.parent = GameObject.Find("Ending Panel").transform;
        activateFromHome = true;

        // Commands to reset the story
        string language = PlayerPrefs.GetString("Language", "English");
        string images = PlayerPrefs.GetString("images", "");
        string achievements = PlayerPrefs.GetString("achievements", "");
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetString("Language", language);
        PlayerPrefs.SetString("images", images);
        PlayerPrefs.SetString("achievements", achievements);
        PlayerPrefs.SetInt("newAchievements", 0);
        PlayerPrefs.SetInt("newAffinity", 0);
        PlayerPrefs.SetInt("grandpaAffinity", 6);
        PlayerPrefs.SetInt("grandmaAffinity", 8);
        PlayerPrefs.SetInt("dadAffinity", 5);
        PlayerPrefs.SetInt("mumAffinity", 4);
        PlayerPrefs.SetInt("nicAffinity", 4);
        PlayerPrefs.SetInt("nicAffinity", 4);
        if (Option1Selected.prologueStory != null) {
            Option1Selected.prologueStory.ResetState();
        }
        if (Option2Selected.prologueStory != null) {
            Option2Selected.prologueStory.ResetState();
        }
        if (Option3Selected.prologueStory != null) {
            Option3Selected.prologueStory.ResetState();
        }
        if (Option4Selected.prologueStory != null) {
            Option4Selected.prologueStory.ResetState();
        }
        if (Option5Selected.prologueStory != null) {
            Option5Selected.prologueStory.ResetState();
        }
        if (Option6Selected.prologueStory != null) {
            Option6Selected.prologueStory.ResetState();
        }
        if (Option7Selected.prologueStory != null) {
            Option7Selected.prologueStory.ResetState();
        }
        if (Option8Selected.prologueStory != null) {
            Option8Selected.prologueStory.ResetState();
        }
        if (Option9Selected.prologueStory != null) {
            Option9Selected.prologueStory.ResetState();
        }
        if (Option10Selected.prologueStory != null) {
            Option10Selected.prologueStory.ResetState();
        }
        
        PlayerPrefs.SetString("sceneToPlay", "Ishak");
        StartCoroutine(unloadRetry());
    }
    IEnumerator unloadRetry() {
        Scene[] scenes = SceneManager.GetAllScenes();
        yield return new WaitForSeconds(0.66f);
        foreach (Scene sc in scenes) {
            if (sc.name == "Retry") {
                SceneManager.UnloadScene(sc.name);
            }
        }
        if (GoToChatAppFromHome.blockingBg != null) {
            Destroy(GoToChatAppFromHome.blockingBg);
        }
    }
}