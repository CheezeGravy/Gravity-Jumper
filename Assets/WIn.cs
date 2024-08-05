using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WIn : MonoBehaviour
{
    [SerializeField] GameObject win_screen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            win_screen.SetActive(true);
        }
    }
}
