using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEndScript : MonoBehaviour
{
	public VideoPlayer video;

	void Start()
	{
		video.loopPointReached += CheckOver;
	}

	void CheckOver(VideoPlayer vp)
	{
		SceneManager.LoadScene(2);
	}
}
