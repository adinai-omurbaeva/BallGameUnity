using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectBall : MonoBehaviour
{   
    void OnTriggerEnter(Collider other)
    {
        if (PlayerCounter.numberCount == BallNumberRandomizer.number)
        {
            PlayerCounter.numberCount *= 2;
            this.gameObject.SetActive(false);
        }
    }
}
