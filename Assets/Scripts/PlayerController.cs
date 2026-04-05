using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 10f;

    void Start()
    {
        // Oyun başladığında topun fiziksel yapısını (Rigidbody) kodun içine alıyoruz ki onu itebilelim.
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementValue)
    {
        // Klavyeden (WASD veya ok tuşları) gelen yön bilgilerini alıyoruz.
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        // Topa X ve Z eksenlerinde (ileri-geri, sağa-sola) güç uygulayarak itiyoruz.
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
}