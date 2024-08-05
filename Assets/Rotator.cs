using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] Grid tilemap;
    [SerializeField] Transform pivot;
    [SerializeField] Transform spawnpoint;
    [SerializeField] float rotate_degree;
    
    private bool animating = false;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player") {
            if (animating == false) {
                Debug.Log("hit");
                animating = true;
                pivot.transform.position = transform.position;
                spawnpoint.transform.position = transform.position;
                tilemap.transform.SetParent(pivot);
                StartCoroutine(Waiter());
            }
        }
    }

    IEnumerator Waiter() {
        Debug.Log("start wait");
        Tween RotateTween = pivot.transform.DORotate(new Vector3(0, 0, rotate_degree), 2);
        RotateTween.PlayForward();
        yield return RotateTween.WaitForCompletion();
        Debug.Log("end wait");
        animating = false;
        tilemap.transform.SetParent(null);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
