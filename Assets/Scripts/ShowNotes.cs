using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowNotes : MonoBehaviour
{
    [SerializeField]GameObject note0;
    [SerializeField]GameObject note1;
    [SerializeField]GameObject note2;
    [SerializeField]GameObject note3;
    [SerializeField]GameObject note4;
    [SerializeField]GameObject note5;
    [SerializeField]GameObject note6;
    [SerializeField]GameObject note7;
    [SerializeField]GameObject note8;
    [SerializeField]GameObject note9;

    void Start()
    {
        if (PlayerPrefs.GetString("sceneToPlay") == "Chapter1") {
            note0.SetActive(true);
        } else if (PlayerPrefs.GetString("sceneToPlay") == "Chapter2") {
            note0.SetActive(true);
            note1.SetActive(true);
        } else if (PlayerPrefs.GetString("sceneToPlay") == "Chapter3") {
            note0.SetActive(true);
            note1.SetActive(true);
            note2.SetActive(true);
        } else if (PlayerPrefs.GetString("sceneToPlay") == "Chapter4") {
            note0.SetActive(true);
            note1.SetActive(true);
            note2.SetActive(true);
            note3.SetActive(true);
        } else if (PlayerPrefs.GetString("sceneToPlay") == "Chapter5") {
            note0.SetActive(true);
            note1.SetActive(true);
            note2.SetActive(true);
            note3.SetActive(true);
            note4.SetActive(true);
        } else if (PlayerPrefs.GetString("sceneToPlay") == "Chapter6") {
            note0.SetActive(true);
            note1.SetActive(true);
            note2.SetActive(true);
            note3.SetActive(true);
            note4.SetActive(true);
            note5.SetActive(true);
        } else if (PlayerPrefs.GetString("sceneToPlay") == "Chapter7") {
            note0.SetActive(true);
            note1.SetActive(true);
            note2.SetActive(true);
            note3.SetActive(true);
            note4.SetActive(true);
            note5.SetActive(true);
            note6.SetActive(true);
        } else if (PlayerPrefs.GetString("sceneToPlay") == "Chapter8") {
            note0.SetActive(true);
            note1.SetActive(true);
            note2.SetActive(true);
            note3.SetActive(true);
            note4.SetActive(true);
            note5.SetActive(true);
            note6.SetActive(true);
            note7.SetActive(true);
        } else if (PlayerPrefs.GetString("sceneToPlay") == "Chapter9") {
            note0.SetActive(true);
            note1.SetActive(true);
            note2.SetActive(true);
            note3.SetActive(true);
            note4.SetActive(true);
            note5.SetActive(true);
            note6.SetActive(true);
            note7.SetActive(true);
            note8.SetActive(true);
        } else if (PlayerPrefs.GetString("sceneToPlay") == "Retry") {
            note0.SetActive(true);
            note1.SetActive(true);
            note2.SetActive(true);
            note3.SetActive(true);
            note4.SetActive(true);
            note5.SetActive(true);
            note6.SetActive(true);
            note7.SetActive(true);
            note8.SetActive(true);
            note9.SetActive(true);
        }
    }
}
