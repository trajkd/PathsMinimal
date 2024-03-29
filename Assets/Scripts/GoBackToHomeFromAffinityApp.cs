﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToHomeFromAffinityApp : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    public void SlideOut() {
        if (MainPanel != null) {
            Animator animator1 = MainPanel.GetComponent<Animator>();
            if (animator1 != null) {
                animator1.SetBool("close", true);
            }
        }
        if (GoToAffinityAppFromHome.blockingBg != null) {
            Destroy(GoToAffinityAppFromHome.blockingBg);
        }
        StartCoroutine("unloadChat");
    }

    IEnumerator unloadChat() {
        yield return new WaitForSeconds(0.66f);
        SceneManager.UnloadScene(gameObject.scene.name);
    }
}
