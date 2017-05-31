using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour {

	public Transform hours, minutes, seconds;

	private const float
		hoursToDegrees = 360 / 12f,
		minutesToDegrees = 360f / 60f,
		secondsToDegrees = 360f / 60f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DateTime time = DateTime.Now;
		hours.localRotation = 
			Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees);
		minutes.localRotation = 
			Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees);
		seconds.localRotation = 
			Quaternion.Euler(0f, 0f, time.Second * -secondsToDegrees);
	}
}
