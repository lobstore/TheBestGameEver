using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spikes : MonoBehaviour
{
    public static readonly UnityEvent onDestroy = new UnityEvent();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            onDestroy.Invoke();
        }
    }

}
