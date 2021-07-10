using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAffinities : MonoBehaviour
{
    [SerializeField]GameObject affinities;
    void Update()
    {
        affinities.transform.localScale = new Vector3(Screen.width/423f, Screen.width/423f, Screen.width/423f);
    }
}
