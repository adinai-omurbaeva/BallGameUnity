using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class BallPointDisplay : MonoBehaviour
{
    public TextMeshPro numberText;

    // Update is called once per frame
    void Update()
    {
        numberText.text = "" + BallNumberRandomizer.number;
    }
}
