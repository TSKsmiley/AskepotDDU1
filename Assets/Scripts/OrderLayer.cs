using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderLayer : MonoBehaviour
{
    public SpriteRenderer sr;
    public SpriteRenderer sr2;
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
        if (sr2) sr2.sortingOrder = 7;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        sr.sortingOrder = 4;
        if (sr2) sr2.sortingOrder = 5;
    }
}
