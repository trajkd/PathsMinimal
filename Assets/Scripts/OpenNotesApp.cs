using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNotesApp : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    void Start()
    {
        if (GoToNotesAppFromHome.activateFromHome) {
            if (MainPanel != null) {
                Animator animator1 = MainPanel.GetComponent<Animator>();
                animator1.SetTrigger("fromHome");
            }
        }
    }
}
