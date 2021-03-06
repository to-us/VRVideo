﻿using UnityEngine;
using UnityEngine.Events;

public class VRPlayerInput : MonoBehaviour
{
    public event UnityAction OnTriggerUp;
    public event UnityAction OnTriggerDown;
    public event UnityAction OnTouchpadUp;
    public event UnityAction OnTouchpadDown;

    private void Update()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (OnTriggerUp != null)
                OnTriggerUp();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            if (OnTriggerDown != null)
                OnTriggerDown();
        }

        if (OVRInput.GetUp(OVRInput.Button.PrimaryTouchpad))
        {
            if (OnTouchpadUp != null)
                OnTouchpadUp();
        }

        if (OVRInput.GetDown(OVRInput.Button.PrimaryTouchpad))
        {
            if (OnTouchpadDown != null)
                OnTouchpadDown();
        }
    }

    private void OnDestroy()
    {
        OnTriggerUp = null;
        OnTriggerDown = null;
        OnTouchpadUp = null;
        OnTouchpadDown = null;
    }
}
