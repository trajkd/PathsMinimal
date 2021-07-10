using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenReplyPanel7 : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    [SerializeField]GameObject ReplyPanel;

    public void OpenPanel() {
        if(GameObject.Find("Reply option").GetComponent<Option8Selected>().selectionPossible) {
            if (MainPanel != null) {
                Animator animator1 = MainPanel.GetComponent<Animator>();
                if (animator1 != null) {
                    bool isOpen = animator1.GetBool("open");
                    animator1.SetBool("open", !isOpen);
                }
            }

            if (ReplyPanel != null) {
                Animator animator2 = ReplyPanel.GetComponent<Animator>();
                if (animator2 != null) {
                    bool isOpen = animator2.GetBool("open");
                    animator2.SetBool("open", !isOpen);
                }
            }
        }
    }
}
