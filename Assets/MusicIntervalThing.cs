using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicIntervalThing : MonoBehaviour
{

	[SerializeField] private AudioClip[] clips;
	private int clipIndex;
	public AudioSource audio;

	void Start()
	{
		StartCoroutine(IPlaySound());
	}

	IEnumerator IPlaySound()
	{
		yield return new WaitForSeconds(Random.Range(60f, 90f));

		clipIndex = Random.Range(0, clips.Length);
		audio.PlayOneShot(clips[clipIndex], 1f);

		yield return new WaitForSeconds(clips[clipIndex].length);
		StartCoroutine(IPlaySound());
	}
}
