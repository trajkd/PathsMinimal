using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAffinityAppFromHome : MonoBehaviour
{
    public string sceneToPlay = "Affinity";
    public static bool activateFromHome = false;
    static GoToAffinityAppFromHome instance;
    public GameObject blockingBackground;
    GameObject bBg;
    public static GameObject blockingBg {get { return instance.bBg; } }
    public void Play() {
        instance = this;
        bBg = Instantiate(blockingBackground) as GameObject;
        bBg.transform.parent = GameObject.Find("Home Main Panel").transform;
        activateFromHome = true;
        SceneManager.LoadScene(sceneToPlay,LoadSceneMode.Additive);
        PlayerPrefs.SetInt("newAffinity", 0);
    }
}
