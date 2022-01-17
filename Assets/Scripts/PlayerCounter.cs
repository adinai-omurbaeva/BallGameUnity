using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PlayerCounter : MonoBehaviour
{
    public static int numberCount = 2;
    public TextMeshPro pointText;
    // Update is called once per frame
    void Update()
    {
        pointText.text = "" + numberCount;
    }
}
