﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Audio;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5f;
    
    public Rigidbody2D rb;

    private Vector2 _movement;

	public AudioSource audio;

    public Animator animator;
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");
    private static readonly int Vertical = Animator.StringToHash("Vertical");
    private static readonly int Speed = Animator.StringToHash("Speed");

	public Canvas escapeMenu;
	public Camera minimapCam;
	public SpriteRenderer redSquare;

    // Update is called once per frame
    void Update() // input
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        
        animator.SetFloat(Horizontal, _movement.x);
        animator.SetFloat(Vertical, _movement.y);
        animator.SetFloat(Speed, _movement.sqrMagnitude );
		
		if ((Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical")) && !audio.isPlaying)
			audio.Play();
		else if (!Input.GetButton("Horizontal") && !Input.GetButton("Vertical") && audio.isPlaying)
			audio.Stop(); // or Pause()



		if (Input.GetKeyDown(KeyCode.Escape))
		{
			escapeMenu.enabled = !escapeMenu.enabled;
		}

		if (Input.GetKeyDown(KeyCode.M))
		{
			minimapCam.enabled = !minimapCam.enabled;
			redSquare.enabled = !redSquare.enabled;
		}



	}

    void FixedUpdate() // movement 
    {
		if (!minimapCam.enabled)
		{
			rb.MovePosition(rb.position + _movement * (moveSpeed * Time.fixedDeltaTime));
		}
	}


}
