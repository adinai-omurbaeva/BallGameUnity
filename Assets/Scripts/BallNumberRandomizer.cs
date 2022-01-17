using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class BallNumberRandomizer : MonoBehaviour
{
    public static System.Random random = new System.Random();
    public static List<int> mylist = new List<int> { 2, 4, 8, 16, 32, 64 };
    public static int number;
    static int randomIndex = random.Next(0, mylist.Count);

    void Awake()
    {
        number = mylist[randomIndex];
    }

}
