using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;

public class InstantisatePrefabBehaviour : XRGrabInteractable
{
    private XRBaseInteractor currentInteractor;
    public UnityEvent onGrab, onRelease;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        onGrab.Invoke();
    }  
    
    protected override void OnSelectExiting(SelectExitEventArgs args)
    {
        base.OnSelectExiting(args);
        onRelease.Invoke();
    }

}
