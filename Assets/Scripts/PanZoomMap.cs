using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanZoomMap : MonoBehaviour {
    Vector3 touchStart;
    float zoomOutMin = 1;
    float zoomOutMax = 8;
    Vector2 ScreenSize;
    bool isReady = false;

    void Start() {
        StartCoroutine(SetIsReady());
    }
    IEnumerator SetIsReady() {
        bool done = false;
        while(!done) {
            if(GameObject.Find("Map Panel").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).normalizedTime > 1) {
                isReady = true;
                done = true;
            }
            yield return null;
        }
    }

	void Update () {
        if (isReady) {
            if(Input.GetMouseButtonDown(0)){
                touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            if(Input.touchCount == 2){
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

                float difference = currentMagnitude - prevMagnitude;

                zoom(difference * 0.01f);
            }else if(Input.GetMouseButton(0)){
                Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                gameObject.transform.position -= direction*2.5f;
                if (GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y > Screen.height) {
                    gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x/2f+(Screen.width-GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x), GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x/2f), Mathf.Clamp(gameObject.transform.position.y, GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y/2f+(Screen.height-GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y), GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y/2f), 0);
                } else {
                    gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x/2f+(Screen.width-GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x), GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x/2f), Mathf.Clamp(gameObject.transform.position.y, GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y/2f, Screen.height-GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y/2f), 0);
                }
            }
            zoom(Input.GetAxis("Mouse ScrollWheel"));
        }
	}

    void zoom(float increment){
        float factor = Mathf.Clamp(gameObject.transform.localScale.x + increment, zoomOutMin, zoomOutMax);
        gameObject.transform.localScale = new Vector3(factor, factor, 0);
        float imageWidth = GetComponent<RectTransform>().rect.width;
        // if ((gameObject.transform.localScale.x + increment) < zoomOutMin && !LeanTween.isTweening(gameObject)) {
        //     LeanTween.scaleX(gameObject, Screen.width/imageWidth, 0.2f).setIgnoreTimeScale(true);
        //     LeanTween.scaleY(gameObject, Screen.width/imageWidth, 0.2f).setIgnoreTimeScale(true);
        // }
        if (GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y > Screen.height) {
            gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x/2f+(Screen.width-GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x), GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x/2f), Mathf.Clamp(gameObject.transform.position.y, GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y/2f+(Screen.height-GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y), GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y/2f), 0);
        } else {
            gameObject.transform.position = new Vector3(Mathf.Clamp(gameObject.transform.position.x, GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x/2f+(Screen.width-GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x), GetComponent<RectTransform>().rect.width*gameObject.transform.localScale.x/2f), Mathf.Clamp(gameObject.transform.position.y, GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y/2f, Screen.height-GetComponent<RectTransform>().rect.height*gameObject.transform.localScale.y/2f), 0);
        }
    }
}