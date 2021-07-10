using UnityEngine;
using System.Collections;

public class PinchZoom : MonoBehaviour
{
    private float scale_factor = 0.07f;
    private float MAXSCALE = 6.0f, MIN_SCALE = 0.6f; // zoom-in and zoom-out limits
    private bool isMousePressed;
    private Vector2 prevDist = new Vector2(0, 0);
    private Vector2 curDist = new Vector2(0, 0);
    private Vector2 midPoint = new Vector2(0, 0);
    private Vector2 ScreenSize;
    private Vector3 originalPos;
    private GameObject parentObject;

    void Start()
    {
        // Game Object will be created and make current object as its child (only because we can set virtual anchor point of gameobject and can zoom in and zoom out from particular position)
        // parentObject = new GameObject("ParentObject");
        // transform.parent = transform.parent;
        // transform.position = new Vector3(transform.position.x * -1, transform.position.y * -1, transform.position.z);
        // transform.parent = transform;

        ScreenSize = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        originalPos = transform.position;
        isMousePressed = false;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            isMousePressed = true;
        else if (Input.GetMouseButtonUp(0))
            isMousePressed = false;
        // These lines of code will pan/drag the object around untill the edge of the image
        if (isMousePressed && Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved && (transform.localScale.x > MIN_SCALE || transform.localScale.y > MIN_SCALE))
        {
            Touch touch = Input.GetTouch(0);
            Vector3 diff = touch.deltaPosition * 0.1f;
            Vector3 pos = transform.position + diff;
            if (pos.x > ScreenSize.x * (transform.localScale.x - 1))
                pos.x = ScreenSize.x * (transform.localScale.x - 1);
            if (pos.x < ScreenSize.x * (transform.localScale.x - 1) * -1)
                pos.x = ScreenSize.x * (transform.localScale.x - 1) * -1;
            if (pos.y > ScreenSize.y * (transform.localScale.y - 1))
                pos.y = ScreenSize.y * (transform.localScale.y - 1);
            if (pos.y < ScreenSize.y * (transform.localScale.y - 1) * -1)
                pos.y = ScreenSize.y * (transform.localScale.y - 1) * -1;
            transform.position = pos;
        }
        // On double tap image will be set at original position and scale
        else if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).tapCount == 2)
        {
            transform.localScale = Vector3.one;
            transform.position = new Vector3(originalPos.x * -1, originalPos.y * -1, originalPos.z);
            transform.position = originalPos;
        }
        checkForMultiTouch();
    }
    // Following method check multi touch 
    private void checkForMultiTouch()
    {
        // These lines of code will take the distance between two touches and zoom in - zoom out at middle point between them
        if (Input.touchCount == 2 && Input.GetTouch(0).phase == TouchPhase.Moved && Input.GetTouch(1).phase == TouchPhase.Moved)
        {
            midPoint = new Vector2(((Input.GetTouch(0).position.x + Input.GetTouch(1).position.x) / 2), ((Input.GetTouch(0).position.y + Input.GetTouch(1).position.y) / 2));
            midPoint = Camera.main.ScreenToWorldPoint(midPoint);

            curDist = Input.GetTouch(0).position - Input.GetTouch(1).position; //current distance between finger touches
            prevDist = ((Input.GetTouch(0).position - Input.GetTouch(0).deltaPosition) - (Input.GetTouch(1).position - Input.GetTouch(1).deltaPosition)); //difference in previous locations using delta positions
            float touchDelta = curDist.magnitude - prevDist.magnitude;
            // Zoom out
            if (touchDelta > 0)
            {
                if (transform.localScale.x < MAXSCALE && transform.localScale.y < MAXSCALE)
                {
                    Vector3 scale = new Vector3(transform.localScale.x + scale_factor, transform.localScale.y + scale_factor, 1);
                    scale.x = (scale.x > MAXSCALE) ? MAXSCALE : scale.x;
                    scale.y = (scale.y > MAXSCALE) ? MAXSCALE : scale.y;
                    scaleFromPosition(scale, midPoint);
                }
            }
            //Zoom in
            else if (touchDelta < 0)
            {
                if (transform.localScale.x > MIN_SCALE && transform.localScale.y > MIN_SCALE)
                {
                    Vector3 scale = new Vector3(transform.localScale.x + scale_factor * -1, transform.localScale.y + scale_factor * -1, 1);
                    scale.x = (scale.x < MIN_SCALE) ? MIN_SCALE : scale.x;
                    scale.y = (scale.y < MIN_SCALE) ? MIN_SCALE : scale.y;
                    scaleFromPosition(scale, midPoint);
                }
            }
        }
        // On touch end just check whether image is within screen or not
        else if (Input.touchCount == 2 && (Input.GetTouch(0).phase == TouchPhase.Ended || Input.GetTouch(0).phase == TouchPhase.Canceled || Input.GetTouch(1).phase == TouchPhase.Ended || Input.GetTouch(1).phase == TouchPhase.Canceled))
        {
            if (transform.localScale.x < 1 || transform.localScale.y < 1)
            {
                transform.localScale = Vector3.one;
                // transform.position = new Vector3(originalPos.x * -1, originalPos.y * -1, originalPos.z);
                // transform.position = originalPos;
            }
            else
            {
                Vector3 pos = transform.position;
                if (pos.x > ScreenSize.x * (transform.localScale.x - 1))
                    pos.x = ScreenSize.x * (transform.localScale.x - 1);
                if (pos.x < ScreenSize.x * (transform.localScale.x - 1) * -1)
                    pos.x = ScreenSize.x * (transform.localScale.x - 1) * -1;
                if (pos.y > ScreenSize.y * (transform.localScale.y - 1))
                    pos.y = ScreenSize.y * (transform.localScale.y - 1);
                if (pos.y < ScreenSize.y * (transform.localScale.y - 1) * -1)
                    pos.y = ScreenSize.y * (transform.localScale.y - 1) * -1;
                // transform.position = pos;
            }
        }
    }
    //Following method scales the gameobject from particular position
    static Vector3 prevPos = Vector3.zero;
    private void scaleFromPosition(Vector3 scale, Vector3 fromPos)
    {
        if (!fromPos.Equals(prevPos))
        {
            Vector3 prevParentPos = transform.position;
            // transform.position = fromPos;
            Vector3 diff = transform.position - prevParentPos;
            Vector3 pos = new Vector3(diff.x / transform.localScale.x * -1, diff.y / transform.localScale.y * -1, transform.position.z);
            // transform.localPosition = new Vector3(transform.localPosition.x + pos.x, transform.localPosition.y + pos.y, pos.z);
        }
        transform.localScale = scale;
        prevPos = fromPos;
    }
}