using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passage : MonoBehaviour
{
    public Transform connection;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 position = collision.gameObject.transform.position;
        position.x = connection.position.x;
        position.y = connection.position.y;
        collision.gameObject.transform.position = position;
    }
}
