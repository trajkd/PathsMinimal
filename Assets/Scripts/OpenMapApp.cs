using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMapApp : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    void Start()
    {
        if (GoToMapAppFromHome.activateFromHome) {
            if (MainPanel != null) {
                Animator animator1 = MainPanel.GetComponent<Animator>();
                animator1.SetTrigger("fromHome");
            }
        }
    }
}
