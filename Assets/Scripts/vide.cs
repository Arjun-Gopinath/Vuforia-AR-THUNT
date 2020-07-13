using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class vide : MonoBehaviour,ITrackableEventHandler {
	public VideoClip my_cip;
	public VideoPlayer my_payer;

	private TrackableBehaviour mTrackableBehaviour;


	void Start()
	{	my_payer.clip = my_cip;

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{
			// Play audio when target is found
			my_payer.Play();
		}
		else
		{
			// Stop audio when target is lost
			my_payer.Stop();
		}
	}   
}
