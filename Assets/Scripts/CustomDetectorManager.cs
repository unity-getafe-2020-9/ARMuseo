using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using Vuforia;

public class CustomDetectorManager : MonoBehaviour, ITrackableEventHandler
{
    public VideoPlayer vp;

    protected TrackableBehaviour mTrackableBehaviour;
    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }


    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        switch (newStatus)
        {
            case TrackableBehaviour.Status.TRACKED:
                Tracked();
                break;
            case TrackableBehaviour.Status.NO_POSE:
                NoPose();
                break;
        }
    }

    /// <summary>
    /// Se invoca cuando no se tiene el target localizado
    /// </summary>
    private void NoPose()
    {
        print("---CUSTOM MANAGER--- NOPOSE");
        vp.Pause();
    }

    /// <summary>
    /// Se invoca cuando el target está localizado
    /// </summary>
    private void Tracked()
    {
        print("---CUSTOM MANAGER--- TRACKED");
        vp.Play();
    }
}
