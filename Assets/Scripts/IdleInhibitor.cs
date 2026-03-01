using UnityEngine;


public class IdleInhibitor : MonoBehaviour
{
    //Adding sleep inhibitor (deny powering off display)
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
