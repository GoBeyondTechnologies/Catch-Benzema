using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickName : MonoBehaviour
{
    public Text name;
    Vector3 namepos;

    void Update()
    {
        namepos = Camera.main.WorldToScreenPoint(this.transform.position);
        name.transform.position = namepos;
    }
}
