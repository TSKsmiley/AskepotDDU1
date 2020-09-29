using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderLayer : MonoBehaviour
{
    public SpriteRenderer sr;
    private void Start()
    {
        if (!sr)
        {
            sr = GetComponent<SpriteRenderer>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        sr.sortingOrder = 6;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        sr.sortingOrder = 4;
    }
}
