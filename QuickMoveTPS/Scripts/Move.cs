using System;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;

    private void Update()
    {
        Vector3 Input = new Vector3(UnityEngine.Input.GetAxis("Horizontal"), 0, UnityEngine.Input.GetAxis("Vertical"));
        rb.MovePosition(rb.position + (Input * (speed * Time.deltaTime)));
    }
}