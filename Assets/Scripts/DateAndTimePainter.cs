using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DateAndTimePainter : MonoBehaviour
{
    [SerializeField]GameObject datego;
    [SerializeField]GameObject timego;
    void Update()
    {
        if (PlayerPrefs.HasKey("date") && PlayerPrefs.HasKey("time")) {
            datego.GetComponent<TextLocalizer>().id = PlayerPrefs.GetString("date");
            timego.GetComponent<TextLocalizer>().id = PlayerPrefs.GetString("time");
            datego.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(PlayerPrefs.GetString("date"));
            timego.GetComponent<TMP_Text>().text = TextLocalizer.ResolveStringValue(PlayerPrefs.GetString("time"));
        }
    }
}
