using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Kameranın kimi takip edeceğini belirteceğimiz boşluk
    public GameObject player;

    // Kamera ile top arasındaki mesafeyi tutacağımız hafıza
    private Vector3 offset;

    void Start()
    {
        // Oyun başlar başlamaz kamera ile top arasındaki o anki mesafeyi ölç ve "offset" içine kaydet.
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        // Top her hareket ettiğinde, kamerayı topun yeni konumuna taşı ama aradaki mesafeyi (offset) koru.
        transform.position = player.transform.position + offset;
    }
}