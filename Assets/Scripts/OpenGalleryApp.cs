using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGalleryApp : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    void Start()
    {
        if (GoToGalleryAppFromHome.activateFromHome) {
            if (MainPanel != null) {
                Animator animator1 = MainPanel.GetComponent<Animator>();
                animator1.SetTrigger("fromHome");
            }
        }
    }
}
