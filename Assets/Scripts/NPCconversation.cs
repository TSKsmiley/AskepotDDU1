using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCconversation : MonoBehaviour
{

    public String[] Dialouge;
    public Canvas canvs;
    public TextMeshProUGUI Text;
    public PlayerController PlayerController;
    public MissionController MissionController;
	public SpriteRenderer questIcon;

    private bool isTalking;
    private int index = 0;
    private NPCconversation _npCconversation;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!this.enabled) return;
        index = 0;
        PlayerController.enabled = false;
        next();
        canvs.enabled = true;
        isTalking = true;
    }

    private void next()
    {
        Text.text = Dialouge[index];
        index++;
    }

	public void startQuest()
	{
		questIcon.enabled = true;
	}
		
    
    // Start is called before the first frame update
    void Start()
    {
        _npCconversation = this.gameObject.GetComponent<NPCconversation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isTalking && Input.GetKeyDown(KeyCode.Space) && Dialouge.Length > index)
        {
            next();
        }
        else if (isTalking && Input.GetKeyDown(KeyCode.Space) && Dialouge.Length <= index)
        {
            _npCconversation.enabled = false;
            isTalking = false;
            canvs.enabled = false;
            PlayerController.enabled = true;
			questIcon.enabled = false;
            MissionController.Next();
        }
    }
}
