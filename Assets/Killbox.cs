using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    [SerializeField] Transform spawnpoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            other.transform.position = spawnpoint.transform.position;
        }
    }
}
