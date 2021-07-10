using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScreenUnlocker : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    Vector3 screenPoint;
    Vector3 offset;
    float limit = 350f;
    private void Start()
    {
        AddPhysics2DRaycaster();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if(eventData.pointerCurrentRaycast.gameObject.name == "Lock screen") {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(screenPoint.x, Input.mousePosition.y*70 , screenPoint.z));
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 cursorScreenPoint = new Vector3 (screenPoint.x, Input.mousePosition.y*70, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint (cursorScreenPoint) + offset;
        if(cursorPosition.y > 0) {
            transform.position = cursorPosition;
        }
        if(cursorPosition.y >= limit) {
            LeanTween.moveY(gameObject, ((RectTransform)gameObject.transform).rect.height, 0.4f);
        }
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Vector3 cursorScreenPoint = new Vector3 (screenPoint.x, Input.mousePosition.y*70, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint (cursorScreenPoint) + offset;
        if(cursorPosition.y < limit) {
            LeanTween.moveY(gameObject, 0, 0.4f);
        }
    }
    private void AddPhysics2DRaycaster()
    {
        Physics2DRaycaster physicsRaycaster = FindObjectOfType<Physics2DRaycaster>();
        if (physicsRaycaster == null)
        {
            Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
        }
    }
}
