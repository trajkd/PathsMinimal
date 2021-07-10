using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ShowUnlockedImages : MonoBehaviour
{
    List<Sprite> unlockedImages;
    void Awake() {
        if (!PlayerPrefs.HasKey("images")) {
            PlayerPrefs.SetString("images", "");
        }
        UnlockImage.images = new List<Sprite>();
        string[] imagesNames = PlayerPrefs.GetString("images").Split('|');
        foreach (string img in imagesNames) {
            UnlockImage.images.Add(Resources.Load<Sprite>("Images/Gallery/"+img));
        }
        unlockedImages = UnlockImage.images;
    }
    void Start() {
        string[] imagesNames = PlayerPrefs.GetString("images").Split('|');
        for (int i = 0; i < this.gameObject.transform.childCount; i++) {
            if (imagesNames.Contains(this.gameObject.transform.GetChild(i).transform.GetChild(0).GetComponent<ImagePositionIdentifier>().id)) {
                this.gameObject.transform.GetChild(i).transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+this.gameObject.transform.GetChild(i).transform.GetChild(0).GetComponent<ImagePositionIdentifier>().id);
            }
        }
    }
}