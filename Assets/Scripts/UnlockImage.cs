using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockImage : MonoBehaviour
{
    public static List<Sprite> images;
    void Awake() {
        if (!PlayerPrefs.HasKey("images")) {
            PlayerPrefs.SetString("images", "");
        }
        images = new List<Sprite>();
        string[] imagesNames = PlayerPrefs.GetString("images").Split('|');
        foreach (string img in imagesNames) {
            images.Add(Resources.Load<Sprite>("Images/Gallery/"+img));
        }
    }
    public void UnlockAnImage(Sprite image) {
        images.Add(image);
    }
}
