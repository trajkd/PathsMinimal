using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToHomeFromChatApp : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    [SerializeField]GameObject whiteCover;
    public void SlideOut() {
        whiteCover.SetActive(false);
        if (MainPanel != null) {
            Animator animator1 = MainPanel.GetComponent<Animator>();
            if (animator1 != null) {
                animator1.SetBool("close", true);
            }
        }
        if (GoToChatAppFromHome.blockingBg != null) {
            Destroy(GoToChatAppFromHome.blockingBg);
        }
        StartCoroutine("unloadChat");
    }

    IEnumerator unloadChat() {
        yield return new WaitForSeconds(0.66f);
        SceneManager.UnloadScene(gameObject.scene.name);
    }
}
