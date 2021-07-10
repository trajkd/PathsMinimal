using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
 
public class ButtonPressedDetector : MonoBehaviour, IPointerDownHandler {
 
    public void OnPointerDown(PointerEventData eventData) {
        Option1Selected.avatarClicked = true;
    }
}
