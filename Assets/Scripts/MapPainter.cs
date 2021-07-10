using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MapPainter : MonoBehaviour
{
    [SerializeField]GameObject map;
    [SerializeField]GameObject grandparentsHouse;
    [SerializeField]GameObject home;
    [SerializeField]GameObject forest;
    [SerializeField]GameObject forestGhost;
    [SerializeField]GameObject lake;
    [SerializeField]GameObject lakeNero;
    [SerializeField]GameObject lakeBianco;
    [SerializeField]GameObject hospital;
    [SerializeField]GameObject school;
    [SerializeField]GameObject lakeNero8;
    [SerializeField]GameObject homeBianco8;
    void Start()
    {
        if (PlayerPrefs.GetString("date") == "date") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappanotturna");
            grandparentsHouse.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date1") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            home.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date2") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            if (PlayerPrefs.GetString("where2", "Home") == "Home") {
                home.SetActive(true);
            } else if (PlayerPrefs.GetString("where2") == "Forest") {
                forest.SetActive(true);
                forestGhost.SetActive(true);
            } else if (PlayerPrefs.GetString("where2") == "Grandparents' house") {
                grandparentsHouse.SetActive(true);
            }
        } else if (PlayerPrefs.GetString("date") == "date3") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            grandparentsHouse.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date4") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            if (PlayerPrefs.GetString("where4", "Grandparents' house") == "Grandparents' house") {
                grandparentsHouse.SetActive(true);
            } else if (PlayerPrefs.GetString("where4") == "Lake") {
                lake.SetActive(true);
            }
            if (PlayerPrefs.GetInt("ghosts_on_the_lake") == 1) {
                lakeNero.SetActive(true);
                lakeBianco.SetActive(true);
            }
        } else if (PlayerPrefs.GetString("date") == "date5") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            grandparentsHouse.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date5_alive") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappapassata");
            hospital.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date5_dead") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappapassata");
            grandparentsHouse.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date6") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            if (PlayerPrefs.GetString("where6", "Grandparents' house") == "Grandparents' house") {
                grandparentsHouse.SetActive(true);
            } else if (PlayerPrefs.GetString("where6") == "Lake") {
                lake.SetActive(true);
            }
        } else if (PlayerPrefs.GetString("date") == "date7_alive") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            grandparentsHouse.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date7_dead") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappapassata");
            grandparentsHouse.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date8_twinsbirth" || PlayerPrefs.GetString("date") == "date8_christmas") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            home.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date8_secondtravel") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappanotturna");
            grandparentsHouse.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date8_thirdtravel") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            if (PlayerPrefs.GetString("where8", "Home") == "Home") {
                home.SetActive(true);
            } else if (PlayerPrefs.GetString("where8", "School") == "School") {
                school.SetActive(true);
            }
            Image lakeNero8image = lakeNero8.GetComponent<Image>();
            Image homeBianco8image = homeBianco8.GetComponent<Image>();
            if (PlayerPrefs.GetInt("failures") == 1) {
                lakeNero8image.color = new Color(lakeNero8image.color.r, lakeNero8image.color.g, lakeNero8image.color.b, 90f);
                homeBianco8image.color = new Color(homeBianco8image.color.r, homeBianco8image.color.g, homeBianco8image.color.b, 90f);
                lakeNero8.SetActive(true);
                homeBianco8.SetActive(true);
            } else if (PlayerPrefs.GetInt("failures") == 2) {
                lakeNero8image.color = new Color(lakeNero8image.color.r, lakeNero8image.color.g, lakeNero8image.color.b, 170f);
                homeBianco8image.color = new Color(homeBianco8image.color.r, homeBianco8image.color.g, homeBianco8image.color.b, 170f);
                lakeNero8.SetActive(true);
                homeBianco8.SetActive(true);
            } else if (PlayerPrefs.GetInt("failures") == 3) {
                lakeNero8image.color = new Color(lakeNero8image.color.r, lakeNero8image.color.g, lakeNero8image.color.b, 255f);
                homeBianco8image.color = new Color(homeBianco8image.color.r, homeBianco8image.color.g, homeBianco8image.color.b, 255f);
                lakeNero8.SetActive(true);
                homeBianco8.SetActive(true);
            }
        } else if (PlayerPrefs.GetString("date") == "date9") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            grandparentsHouse.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date9_alternate") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappaalternativa");
            home.SetActive(true);
            forestGhost.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date9_savetwins") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappagiornaliera");
            lake.SetActive(true);
        } else if (PlayerPrefs.GetString("date") == "date9_savegrandma") {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappanotturna");
            grandparentsHouse.SetActive(true);
        } else {
            map.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Maps/mappanotturna");
            grandparentsHouse.SetActive(true);
        }
    }
}
