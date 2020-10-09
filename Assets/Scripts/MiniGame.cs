using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class MiniGame : MonoBehaviour
{
    public bool isActive;
    public int missionClicks;
    public String text;
    public TextMeshProUGUI statusText;
    public MissionController misnController;
    public Animator Anim;
    public List<GameObject> Wheat;
    public SpriteRenderer Flour;

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!enabled) return;
        isActive = true;
        statusText.text = "Tryk på E " + missionClicks + " Gange For at " + text;
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
            Anim.enabled = true;
            missionClicks--;
            if (missionClicks == 0)
            {
                Flour.enabled = false;
                statusText.text = null;
                misnController.Next();
                enabled = false;
                Anim.enabled = false;
            }
            else
            {
                try
                {
                    Wheat[0].GetComponent<SpriteRenderer>().enabled = false;
                    Wheat.RemoveAt(0);
                }
                catch (Exception e)
                {
                    Flour.enabled = true;
                }
                statusText.text = "Tryk på E " + missionClicks + " Gange For at " + text;
            }
        }
    }
}
