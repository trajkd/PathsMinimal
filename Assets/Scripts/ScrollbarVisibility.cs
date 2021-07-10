 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
public class ScrollbarVisibility : MonoBehaviour
{
    float lastValue = 0;
    [SerializeField]GameObject handle;
    void Update()
    {
        if(!ImageClick.zoomed) {
            if (gameObject.GetComponent<Scrollbar>().value != lastValue) {
                LeanTween.alpha(handle.GetComponent<RectTransform>(), 1f, 0.2f);
            } else {
                LeanTween.alpha(handle.GetComponent<RectTransform>(), 0f, 0.2f);
            }
            lastValue = gameObject.GetComponent<Scrollbar>().value;
        }
    }
}