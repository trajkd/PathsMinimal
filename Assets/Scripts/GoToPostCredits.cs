using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPostCredits : MonoBehaviour
{
    public static bool activateFromHome = false;
    static GoToPostCredits instance;
    public GameObject blockingBackground;
    GameObject bBg;
    public static GameObject blockingBg {get { return instance.bBg; } }
    public void Play() {
        instance = this;
        bBg = Instantiate(blockingBackground) as GameObject;
        bBg.transform.parent = GameObject.Find("Ending Panel").transform;
        activateFromHome = true;
        
        SceneManager.LoadScene("Retry",LoadSceneMode.Additive);
        StartCoroutine(unloadCredits());
    }
    IEnumerator unloadCredits() {
        Scene[] scenes = SceneManager.GetAllScenes();
        yield return new WaitForSeconds(0.66f);
        foreach (Scene sc in scenes) {
            if (sc.name == "Credits") {
                SceneManager.UnloadScene(sc.name);
            }
        }
        if (GoToChatAppFromHome.blockingBg != null) {
            Destroy(GoToChatAppFromHome.blockingBg);
        }
    }
}