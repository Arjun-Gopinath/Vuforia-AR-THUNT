using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class Audio_Enable : MonoBehaviour,ITrackableEventHandler{
	
		private TrackableBehaviour mTrackableBehaviour;
	public AudioSource my_audio;
	public AudioClip my_Clip;

		void Start()
	{	my_audio.clip = my_Clip;
		
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
			my_audio.Play();
			}
			else
			{
				// Stop audio when target is lost
			my_audio.Stop();
			}
		}   
	}
