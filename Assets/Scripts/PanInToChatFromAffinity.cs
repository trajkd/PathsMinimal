using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanInToChatFromAffinity : MonoBehaviour
{
    [SerializeField]GameObject ProfileMainPanel;
    public void Start() {
        Option1Selected.avatarClicked = false;
        if (ProfileMainPanel != null) {
            Animator animator1 = ProfileMainPanel.GetComponent<Animator>();
            animator1.SetBool("panIn", false);
            animator1.SetTrigger("fromChat");
        }
    }

    public void PanIn() {
        if (ProfileMainPanel != null) {
            Animator animator1 = ProfileMainPanel.GetComponent<Animator>();
            animator1.SetBool("panIn", true);
        }
        StartCoroutine("unloadProfile");
    }

    IEnumerator unloadProfile() {
        yield return new WaitForSecondsRealtime(0.66f);
        if (GoToIshakProfile.blockingBg != null) {
            Destroy(GoToIshakProfile.blockingBg);
        }
        SceneManager.UnloadScene(gameObject.scene.name);
    }
}
