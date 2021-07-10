using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GeneralAffinityPainter : MonoBehaviour
{
    Dictionary<string, Dictionary<string, string>> avatarNamesTranslations;
    Dictionary<string, int> avatarAffinities;
    [SerializeField]GameObject daveAffinityGo;
    void Start()
    {
        GameObject.Find("Vertical layout for affinities").transform.position = new Vector3(GameObject.Find("Vertical layout for affinities").transform.position.x, -65f, GameObject.Find("Vertical layout for affinities").transform.position.z);
        avatarNamesTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["nonno_avatarQ"] = "Grandpa",
                ["nonna2_avatarQ"] = "Grandma",
                ["papà_avatarQ"] = "Dad",
                ["mamma_avatarQ"] = "Mom",
                ["nicholas_avatarQ"] = "Nicholas",
                ["tommy_avatarQ"] = "Tommy",
                ["dave_avatarQ"] = "Dave",
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["nonno_avatarQ"] = "Nonno",
                ["nonna2_avatarQ"] = "Nonna",
                ["papà_avatarQ"] = "Papà",
                ["mamma_avatarQ"] = "Mamma",
                ["nicholas_avatarQ"] = "Nicholas",
                ["tommy_avatarQ"] = "Tommy",
                ["dave_avatarQ"] = "Dave",
            }
        };
        avatarAffinities = new Dictionary<string, int>() {
            ["nonno_avatarQ"] = PlayerPrefs.GetInt("grandpaAffinity", 6),
            ["nonna2_avatarQ"] = PlayerPrefs.GetInt("grandmaAffinity", 8),
            ["papà_avatarQ"] = PlayerPrefs.GetInt("dadAffinity", 5),
            ["mamma_avatarQ"] = PlayerPrefs.GetInt("mumAffinity", 4),
            ["nicholas_avatarQ"] = PlayerPrefs.GetInt("nicAffinity", 4),
            ["tommy_avatarQ"] = PlayerPrefs.GetInt("tommyAffinity", 4),
            ["dave_avatarQ"] = PlayerPrefs.GetInt("daveAffinity", 5)
        };
        foreach(Transform child in GameObject.Find("Vertical layout for affinities").transform) {
            string spritename = child.Find("Circular mask/Big character image").gameObject.GetComponent<Image>().sprite.name;
            child.Find("Name").gameObject.GetComponent<TMP_Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][spritename];
            if(avatarAffinities[spritename] == 1) {
                child.Find("Horizontal layout/Horizontal layout 1/Heart 1").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 1/Heart 2").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 3").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 4").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 5").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 6").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 7").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 8").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 9").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 10").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else if(avatarAffinities[spritename] == 2) {
                child.Find("Horizontal layout/Horizontal layout 1/Heart 1").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 1/Heart 2").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 3").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 4").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 5").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 6").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 7").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 8").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 9").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 10").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else if(avatarAffinities[spritename] == 3) {
                child.Find("Horizontal layout/Horizontal layout 1/Heart 1").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 1/Heart 2").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 3").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 4").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 5").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 6").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 7").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 8").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 9").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 10").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else if(avatarAffinities[spritename] == 4) {
                child.Find("Horizontal layout/Horizontal layout 1/Heart 1").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 1/Heart 2").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 3").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 4").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 5").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 6").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 7").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 8").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 9").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 10").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else if(avatarAffinities[spritename] == 5) {
                child.Find("Horizontal layout/Horizontal layout 1/Heart 1").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 1/Heart 2").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 3").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 4").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 5").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 6").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 7").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 8").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 9").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 10").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else if(avatarAffinities[spritename] == 6) {
                child.Find("Horizontal layout/Horizontal layout 1/Heart 1").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 1/Heart 2").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 3").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 4").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 5").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 6").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 7").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 8").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 9").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 10").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else if(avatarAffinities[spritename] == 7) {
                child.Find("Horizontal layout/Horizontal layout 1/Heart 1").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 1/Heart 2").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 3").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 4").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 5").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 6").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 7").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 8").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 9").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 10").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else if(avatarAffinities[spritename] == 8) {
                child.Find("Horizontal layout/Horizontal layout 1/Heart 1").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 1/Heart 2").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 3").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 4").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 5").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 6").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 7").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 8").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 9").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 10").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else if(avatarAffinities[spritename] == 9) {
                child.Find("Horizontal layout/Horizontal layout 1/Heart 1").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 1/Heart 2").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 3").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 4").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 5").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 6").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 7").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 8").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 9").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 10").gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            }
            else if(avatarAffinities[spritename] == 10) {
                child.Find("Horizontal layout/Horizontal layout 1/Heart 1").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 1/Heart 2").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 3").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 2/Heart 4").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 5").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 3/Heart 6").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 7").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 4/Heart 8").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 9").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
                child.Find("Horizontal layout/Horizontal layout 5/Heart 10").gameObject.GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            }
        }
        if (PlayerPrefs.HasKey("sceneToPlay")) {
            daveAffinityGo.SetActive(true);
        }
    }
}
