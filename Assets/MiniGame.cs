using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class MiniGame : MonoBehaviour
{
    public bool isActive;
    public int missionClicks;
    public String text;
    public TextMeshProUGUI statusText;
    
    private int _clicks;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!enabled) return;
        isActive = true;
        statusText.text = text;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!enabled) return;
        isActive = false;
        statusText.text = null;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isActive)
        {
            _clicks++;
            if (_clicks >= missionClicks)
            {
                statusText.text = null;
                enabled = false;
            }
        }
    }
}
