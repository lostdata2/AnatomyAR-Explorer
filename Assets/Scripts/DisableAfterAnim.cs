using System;
using UnityEngine;

public class DisableAfterAnim : MonoBehaviour
{
    [SerializeField] private Animator AnimatorForWait;
    [SerializeField] private string StateForWait;
    [SerializeField] private GameObject ForSetInactive;
    [SerializeField] private bool IsListening = false;
    
    public void StartListening()
    {
        IsListening = true;
    }
    
    private void Check()
    {
        if (AnimatorForWait.GetCurrentAnimatorStateInfo(0).IsName(StateForWait))
        {
            IsListening = false;
            ForSetInactive.SetActive(false);
        }
    }
    
    private void Update()
    {
        if (IsListening) Check();
    }
}
