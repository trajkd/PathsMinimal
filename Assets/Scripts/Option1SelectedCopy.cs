using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Option1SelectedCopy : MonoBehaviour
{
    [SerializeField]GameObject reply;
    [SerializeField]GameObject response;
    [SerializeField]List<string> responseSequence;
    bool pressed = false;
    public void Start() {
        ScrollRect scrollrect = GameObject.Find("Scroll View").GetComponent<ScrollRect>();
        scrollrect.verticalNormalizedPosition = 0;
        LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)scrollrect.transform);
    }
    public void PlayResponse() {
        if (!pressed) {
            StartCoroutine(Seq());
        }
    }
    IEnumerator Seq() {
        yield return PaintResponse();
        yield return ScrollDown();
    }
    IEnumerator PaintResponse() {
        pressed = true;
        yield return ScrollDown();
        GameObject replygo = Instantiate(reply) as GameObject;
        replygo.transform.parent = GameObject.Find("Content").transform;
        Transform replytext = replygo.transform.Find("Textbox container/Player text/Text (TMP)");
        replytext.GetComponent<TMP_Text>().text = "Where r u ish?";
        yield return ScrollDown();
        yield return new WaitForSeconds(2f);
        yield return ScrollDown();
        GameObject response1go = Instantiate(response) as GameObject;
        response1go.transform.parent = GameObject.Find("Content").transform;
        Transform response1text = response1go.transform.Find("Textbox container/Player text/Text (TMP)");
        response1text.GetComponent<TMP_Text>().text = "stay where you are";
        yield return ScrollDown();
        yield return new WaitForSeconds(2f);
        yield return ScrollDown();
        GameObject response2go = Instantiate(response) as GameObject;
        response2go.transform.parent = GameObject.Find("Content").transform;
        Transform response2text = response2go.transform.Find("Textbox container/Player text/Text (TMP)");
        response2text.GetComponent<TMP_Text>().text = "We just haf to hide";
        yield return ScrollDown();
        yield return new WaitForSeconds(2f);
        yield return ScrollDown();
        GameObject response3go = Instantiate(response) as GameObject;
        response3go.transform.parent = GameObject.Find("Content").transform;
        Transform response3text = response3go.transform.Find("Textbox container/Player text/Text (TMP)");
        response3text.GetComponent<TMP_Text>().text = "Stick with the rest";
        yield return ScrollDown();
        yield return new WaitForSeconds(2f);
        yield return ScrollDown();
        GameObject response4go = Instantiate(response) as GameObject;
        response4go.transform.parent = GameObject.Find("Content").transform;
        Transform response4text = response4go.transform.Find("Textbox container/Player text/Text (TMP)");
        response4text.GetComponent<TMP_Text>().text = "I will find u";
        yield return null;
    }
    IEnumerator ScrollDown() {
        ScrollRect scrollrect = GameObject.Find("Scroll View").GetComponent<ScrollRect>();
        yield return new WaitForEndOfFrame();
        scrollrect.verticalNormalizedPosition = 0;
        LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)scrollrect.transform);
    }
}
