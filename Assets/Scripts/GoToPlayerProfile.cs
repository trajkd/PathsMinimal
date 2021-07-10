using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPlayerProfile : MonoBehaviour
{
    public string sceneToPlay = "PlayerProfile";
    static GoToPlayerProfile instance;
    public GameObject blockingBackground;
    GameObject bBg;
    public static GameObject blockingBg {get { return instance.bBg; } }
    public void Play() {
        instance = this;
        bBg = Instantiate(blockingBackground) as GameObject;
        bBg.transform.parent = GameObject.Find("Main Panel").transform;
        SceneManager.LoadScene(sceneToPlay,LoadSceneMode.Additive);
        PlayerPrefs.SetInt("newAchievements", 0);
    }
}
