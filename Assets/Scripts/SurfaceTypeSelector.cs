using System;
using JetBrains.Annotations;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurfaceTypeSelector : MonoBehaviour
{

    public void Horizontal()
    {
        SceneManager.LoadScene(1);
    }
    public void Vertical()
    {
        SceneManager.LoadScene(2);
    }
}
