using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanInToChat : MonoBehaviour
{
    [SerializeField]GameObject ProfileMainPanel;
    public void Start() {
        Option1Selected.avatarClicked = false;
        if(GoToAchievementAppFromHome.activateFromHome) {
            if (ProfileMainPanel != null) {
                Animator animator1 = ProfileMainPanel.GetComponent<Animator>();
                animator1.SetTrigger("fromHome");
            }
        }
        else {
            if (ProfileMainPanel != null) {
                Animator animator1 = ProfileMainPanel.GetComponent<Animator>();
                animator1.SetTrigger("fromChat");
                animator1.SetBool("panIn", false);
            }
        }
    }

    public void PanIn() {
        if(GoToAchievementAppFromHome.activateFromHome) {
            GoToAchievementAppFromHome.activateFromHome = false;
            if (ProfileMainPanel != null) {
                Animator animator1 = ProfileMainPanel.GetComponent<Animator>();
                animator1.SetBool("close", true);
            }
            if (GoToAchievementAppFromHome.blockingBg != null) {
                Destroy(GoToAchievementAppFromHome.blockingBg);
            }
        } else {
            if (GoToPlayerProfile.blockingBg != null) {
                Destroy(GoToPlayerProfile.blockingBg);
            }
            if (ProfileMainPanel != null) {
                Animator animator1 = ProfileMainPanel.GetComponent<Animator>();
                animator1.SetBool("panIn", true);
            }
        }
        StartCoroutine("unloadProfile");
    }

    IEnumerator unloadProfile() {
        yield return new WaitForSecondsRealtime(0.66f);
        SceneManager.UnloadScene(gameObject.scene.name);
    }
}
