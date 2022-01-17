using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollider : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        PlayerCounter.numberCount /= 2;
        this.gameObject.SetActive(false);      
    }
}
