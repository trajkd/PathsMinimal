using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNote : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    void Start()
    {
        if (MainPanel != null) {
            Animator animator1 = MainPanel.GetComponent<Animator>();
            animator1.SetBool("openNote", true);
        }
    }
}
