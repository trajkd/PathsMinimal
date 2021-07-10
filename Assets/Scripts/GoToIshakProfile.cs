using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoToIshakProfile : MonoBehaviour
{
    public string sceneToPlay = "IshakProfile";
    public static Sprite character;
    static GoToIshakProfile instanceChar;
    public GameObject blockingBackground;
    GameObject bBg;
    public static GameObject blockingBg {get { return instanceChar.bBg; } }
    public void Play() {
        if(transform.GetChild(0).gameObject.GetComponent<Image>().sprite.name != "pastbea_avatarQ" && transform.GetChild(0).gameObject.GetComponent<Image>().sprite.name != "segretaria_avatarQ" && transform.GetChild(0).gameObject.GetComponent<Image>().sprite.name != "recruiter_avatarQ") {
            instanceChar = this;
            bBg = Instantiate(blockingBackground) as GameObject;
            bBg.transform.parent = GameObject.Find("Main Panel").transform;
            if (Option1Selected.affinityTooltipgo != null) {
                Destroy(Option1Selected.affinityTooltipgo);
            }
            if(transform.GetChild(0).gameObject.GetComponent<Image>().sprite.name == "nonna70_avatarQ") {
                character = Resources.Load<Sprite>("Images/Avatar/"+"nonna2_avatarQhigh");
                SceneManager.LoadScene(sceneToPlay,LoadSceneMode.Additive);
            } else {
                character = Resources.Load<Sprite>("Images/Avatar/"+transform.GetChild(0).gameObject.GetComponent<Image>().sprite.name+"high");
                SceneManager.LoadScene(sceneToPlay,LoadSceneMode.Additive);
            }
        }
    }
}
