using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{
    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.right) * 10, Color.black);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector3.right), 10f);
        if (hit)
        {
            Debug.Log($"Hedef var.\n{hit.collider.name}");
            hit.rigidbody.AddForce(Vector2.up * 20);
        }
    }
}
