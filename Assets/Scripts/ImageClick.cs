using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageClick : MonoBehaviour
{
    static GameObject theImage;
    static GameObject originalParent;
    public static bool zoomed = false;
    void Update() {
        if (zoomed) {
            Time.timeScale = 0f;
        } else {
            Time.timeScale = 1f;
        }
    }
    public void OnClick()
    {
        if (!zoomed) {
            zoomed = true;
            theImage = gameObject;
            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+gameObject.GetComponent<Image>().sprite.name+"high");
            originalParent = transform.parent.gameObject;
            transform.parent = GameObject.Find("3rd order").transform;
            LeanTween.move(gameObject, new Vector3(Screen.width*0.5f, Screen.height*0.5f, 0), 0.2f).setIgnoreTimeScale(true);
            float worldScreenHeight = Camera.main.orthographicSize * 2.0f;
            float worldScreenWidth = (worldScreenHeight / Screen.height) * Screen.width;
            float imageWidth = GetComponent<RectTransform>().rect.width;
            LeanTween.scaleX(gameObject, Screen.width/imageWidth, 0.2f).setIgnoreTimeScale(true);
            LeanTween.scaleY(gameObject, Screen.width/imageWidth, 0.2f).setIgnoreTimeScale(true);
            GameObject.Find("Zoom background").GetComponent<Image>().raycastTarget = true;
            RectTransform zoomBg = GameObject.Find("Zoom background").GetComponent<RectTransform>();
            LeanTween.alpha(zoomBg, 1f, 0.2f).setIgnoreTimeScale(true);
            GameObject.Find("Back from zoom").GetComponent<Image>().raycastTarget = true;
            RectTransform backFromZoomButton = GameObject.Find("Back from zoom").GetComponent<RectTransform>();
            LeanTween.alpha(backFromZoomButton, 1f, 0.2f).setIgnoreTimeScale(true);
        }
    }
    public void OnBackClick() {
        GameObject.Find("Zoom background").GetComponent<Image>().raycastTarget = false;
        RectTransform zoomBg = GameObject.Find("Zoom background").GetComponent<RectTransform>();
        LeanTween.alpha(zoomBg, 0f, 0.2f).setIgnoreTimeScale(true);
        GameObject.Find("Back from zoom").GetComponent<Image>().raycastTarget = false;
        RectTransform backFromZoomButton = GameObject.Find("Back from zoom").GetComponent<RectTransform>();
        LeanTween.alpha(backFromZoomButton, 0f, 0.2f).setIgnoreTimeScale(true);
        LeanTween.scaleX(theImage, 1f, 0.2f).setIgnoreTimeScale(true);
        LeanTween.scaleY(theImage, 1f, 0.2f).setIgnoreTimeScale(true);
        LeanTween.move(theImage, originalParent.transform.Find("Still image").transform, 0.2f).setIgnoreTimeScale(true);
        theImage.transform.parent = originalParent.transform;
        theImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Gallery/"+theImage.GetComponent<Image>().sprite.name.Substring(0, theImage.GetComponent<Image>().sprite.name.Length - 4));
        zoomed = false;
    }
}