using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update her saniyede onlarca kez çalışır, animasyonlar için harikadır.
    void Update()
    {
        // Küpü X, Y ve Z eksenlerinde yavaşça ve pürüzsüzce döndür.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}