using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AffinityPainter : MonoBehaviour
{
    Dictionary<string, Dictionary<string, string>> avatarNamesTranslations;
    Dictionary<string, int> avatarAffinities;
    void Start()
    {
        avatarNamesTranslations = new Dictionary<string, Dictionary<string, string>>() {
            ["English"] = new Dictionary<string, string>() {
                ["nonno_avatarQhigh"] = "Grandpa",
                ["nonna2_avatarQhigh"] = "Grandma",
                ["papà_avatarQhigh"] = "Dad",
                ["mamma_avatarQhigh"] = "Mom",
                ["nicholas_avatarQhigh"] = "Nicholas",
                ["tommy_avatarQhigh"] = "Tommy",
                ["dave_avatarQhigh"] = "Dave",
            },
            ["Italiano"] = new Dictionary<string, string>() {
                ["nonno_avatarQhigh"] = "Nonno",
                ["nonna2_avatarQhigh"] = "Nonna",
                ["papà_avatarQhigh"] = "Papà",
                ["mamma_avatarQhigh"] = "Mamma",
                ["nicholas_avatarQhigh"] = "Nicholas",
                ["tommy_avatarQhigh"] = "Tommy",
                ["dave_avatarQhigh"] = "Dave",
            }
        };
        avatarAffinities = new Dictionary<string, int>() {
            ["nonno_avatarQhigh"] = PlayerPrefs.GetInt("grandpaAffinity", 6),
            ["nonna2_avatarQhigh"] = PlayerPrefs.GetInt("grandmaAffinity", 8),
            ["papà_avatarQhigh"] = PlayerPrefs.GetInt("dadAffinity", 5),
            ["mamma_avatarQhigh"] = PlayerPrefs.GetInt("mumAffinity", 4),
            ["nicholas_avatarQhigh"] = PlayerPrefs.GetInt("nicAffinity", 4),
            ["tommy_avatarQhigh"] = PlayerPrefs.GetInt("tommyAffinity", 4),
            ["dave_avatarQhigh"] = PlayerPrefs.GetInt("daveAffinity", 5)
        };
        GameObject.Find("Circular mask/Big character image").GetComponent<Image>().sprite = GoToIshakProfile.character;
        GameObject.Find("Profile Main Panel/Top bar/Title").GetComponent<Text>().text = avatarNamesTranslations[TextLocalizer.CurrentLanguage][GoToIshakProfile.character.name];
        if (avatarAffinities[GoToIshakProfile.character.name] == 1) {
            GameObject.Find("Horizontal layout 1/Heart 1").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 1/Heart 2").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 2/Heart 3").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 2/Heart 4").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 3/Heart 5").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 3/Heart 6").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 7").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 8").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 9").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 10").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if (TextLocalizer.CurrentLanguage == "Italiano") {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relazione: Negativa";
            } else {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Negative";
            }
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(149, 6, 0, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 2) {
            GameObject.Find("Horizontal layout 1/Heart 1").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 1/Heart 2").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 3").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 2/Heart 4").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 3/Heart 5").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 3/Heart 6").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 7").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 8").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 9").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 10").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if (TextLocalizer.CurrentLanguage == "Italiano") {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relazione: Negativa";
            } else {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Negative";
            }
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(149, 6, 0, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 3) {
            GameObject.Find("Horizontal layout 1/Heart 1").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 1/Heart 2").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 3").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 4").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 3/Heart 5").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 3/Heart 6").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 7").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 8").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 9").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 10").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if (TextLocalizer.CurrentLanguage == "Italiano") {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relazione: Negativa";
            } else {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Negative";
            }
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(149, 6, 0, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 4) {
            GameObject.Find("Horizontal layout 1/Heart 1").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 1/Heart 2").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 3").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 4").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 5").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 3/Heart 6").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 7").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 8").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 9").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 10").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if (TextLocalizer.CurrentLanguage == "Italiano") {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relazione: Negativa";
            } else {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Negative";
            }
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(149, 6, 0, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 5) {
            GameObject.Find("Horizontal layout 1/Heart 1").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 1/Heart 2").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 3").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 4").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 5").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 6").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 7").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 8").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 9").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 10").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if (TextLocalizer.CurrentLanguage == "Italiano") {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relazione: Neutrale";
            } else {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Neutral";
            }
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(100, 100, 100, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 6) {
            GameObject.Find("Horizontal layout 1/Heart 1").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 1/Heart 2").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 3").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 4").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 5").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 6").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 4/Heart 7").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 4/Heart 8").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 9").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 10").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if (TextLocalizer.CurrentLanguage == "Italiano") {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relazione: Positiva";
            } else {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Positive";
            }
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(0, 149, 2, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 7) {
            GameObject.Find("Horizontal layout 1/Heart 1").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 1/Heart 2").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 3").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 4").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 5").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 6").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 4/Heart 7").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 4/Heart 8").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 9").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 10").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if (TextLocalizer.CurrentLanguage == "Italiano") {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relazione: Positiva";
            } else {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Positive";
            }
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(0, 149, 2, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 8) {
            GameObject.Find("Horizontal layout 1/Heart 1").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 1/Heart 2").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 3").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 4").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 5").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 6").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 4/Heart 7").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 4/Heart 8").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 5/Heart 9").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            GameObject.Find("Horizontal layout 5/Heart 10").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if (TextLocalizer.CurrentLanguage == "Italiano") {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relazione: Positiva";
            } else {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Positive";
            }
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(0, 149, 2, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 9) {
            GameObject.Find("Horizontal layout 1/Heart 1").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 1/Heart 2").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 3").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 4").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 5").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 6").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 4/Heart 7").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 4/Heart 8").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 5/Heart 9").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 5/Heart 10").GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if (TextLocalizer.CurrentLanguage == "Italiano") {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relazione: Positiva";
            } else {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Positive";
            }
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(0, 149, 2, 255);
        }
        else if (avatarAffinities[GoToIshakProfile.character.name] == 10) {
            GameObject.Find("Horizontal layout 1/Heart 1").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 1/Heart 2").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 3").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 2/Heart 4").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 5").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 3/Heart 6").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 4/Heart 7").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 4/Heart 8").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 5/Heart 9").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            GameObject.Find("Horizontal layout 5/Heart 10").GetComponent<Image>().color = new Color32(187, 69, 135, 255);
            if (TextLocalizer.CurrentLanguage == "Italiano") {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relazione: Positiva";
            } else {
                GameObject.Find("Relationship").GetComponent<TMP_Text>().text = "Relationship: Positive";
            }
            GameObject.Find("Relationship").GetComponent<TMP_Text>().color = new Color32(0, 149, 2, 255);
        }
    }
}
