using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationPainter : MonoBehaviour
{
    [SerializeField]GameObject achievementNotification;
    [SerializeField]GameObject affinityNotification;
    [SerializeField]GameObject imageNotification;
    [SerializeField]GameObject chatNotification;
    void Update()
    {
        if (PlayerPrefs.GetInt("newAchievements", 0) == 1) {
            achievementNotification.SetActive(true);
        } else {
            achievementNotification.SetActive(false);
        }
        if (PlayerPrefs.GetInt("newAffinity", 0) == 1) {
            affinityNotification.SetActive(true);
        } else {
            affinityNotification.SetActive(false);
        }
        if (PlayerPrefs.GetInt("newAffinity", 0) == 1) {
            imageNotification.SetActive(true);
        } else {
            imageNotification.SetActive(false);
        }
        if (PlayerPrefs.GetInt("newChat", 1) == 0) {
            chatNotification.SetActive(false);
        } else {
            chatNotification.SetActive(true);
        }
    }
}
