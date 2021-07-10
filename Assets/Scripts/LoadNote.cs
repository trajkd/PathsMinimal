using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNote : MonoBehaviour
{
    public string noteToPlay;
    public void PlayNote()
    {
        SceneManager.LoadScene(noteToPlay, LoadSceneMode.Additive);
    }
}
