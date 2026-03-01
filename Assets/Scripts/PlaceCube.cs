using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.ARFoundation.Samples;

public class PlaceCube : MonoBehaviour
{
    private TouchManagerAPI _touchManager;
    
    [SerializeField] private GameObject XROrigin;
    private bool IsPlacingAllowed = false;

    private void Awake()
    {
        _touchManager = new TouchManagerAPI();
    }

    private void OnEnable()
    {
        _touchManager.Enable();
    }

    private void OnDisable()
    {
        _touchManager.Disable();
    }

    public void AllowPlacing()
    {
        XROrigin.GetComponent<RaycastEventController>().enabled = true;
        IsPlacingAllowed = true;
    }
    private void DenyPlacing()
    {
        XROrigin.GetComponent<RaycastEventController>().enabled = false;
        IsPlacingAllowed = false;
    }

    void StartTouch(InputAction.CallbackContext ctx)
    { 
        Debug.Log("Touch Detected");
        if (IsPlacingAllowed)
        {
            DenyPlacing();
        }
    }
    
    void Start()
    {
        _touchManager.Touch1.TouchState.started += ctx => StartTouch(ctx); //subscribing on event
        XROrigin.GetComponent<RaycastEventController>().enabled = false; //deny placing on start if allowed
    }
}
