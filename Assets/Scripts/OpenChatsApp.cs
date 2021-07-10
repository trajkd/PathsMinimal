using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChatsApp : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    [SerializeField]GameObject whiteCover;
    void Start()
    {
        if (GoToChatAppFromHome.activateFromHome) {
            GoToChatAppFromHome.activateFromHome = false;
            if (MainPanel != null) {
                Animator animator1 = MainPanel.GetComponent<Animator>();
                animator1.SetTrigger("fromHome");
            }
        } else {
            if (MainPanel != null) {
                Animator animator1 = MainPanel.GetComponent<Animator>();
                animator1.SetTrigger("notFromHome");
            }
        }
        StartCoroutine(AddCover());
    }
    IEnumerator AddCover() {
        bool done = false;
        while(!done) {
            if(MainPanel.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1) {
                whiteCover.SetActive(true);
                done = true;
            }
            yield return null;
        }
    }
}
