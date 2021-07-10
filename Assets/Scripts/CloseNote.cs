using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseNote : MonoBehaviour
{
    [SerializeField]GameObject MainPanel;
    public void Close()
    {
        if (MainPanel != null) {
            Animator animator1 = MainPanel.GetComponent<Animator>();
            animator1.SetBool("openNote", false);
        }

        StartCoroutine("unloadNote");
    }

    IEnumerator unloadNote() {
        yield return new WaitForSeconds(0.66f);
        SceneManager.UnloadScene(gameObject.scene.name);
    }
}
