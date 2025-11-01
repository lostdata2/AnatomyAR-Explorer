using UnityEngine;
using UnityEngine.InputSystem;
using TouchPhase = UnityEngine.TouchPhase;

public class RotateAtCamera : MonoBehaviour
{
    private TouchManagerAPI _touchManager;
    
    [SerializeField] private Transform Cube = null;
    private Transform Camera = null;
    private Quaternion RotationShellPrev;
    private Quaternion RotationShellDiff;
    private Quaternion RotationCubePrev;

    private bool IsTouching = false;
    private Vector2 TouchDelta;

    [SerializeField] private float RotationSpeed;
    
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
    
    void ProceedRotation()
    { 
        if (IsTouching) 
        { 
            float RotationX = -_touchManager.Touch1.TouchDelta.ReadValue<Vector2>().y * RotationSpeed;
            float RotationY = -_touchManager.Touch1.TouchDelta.ReadValue<Vector2>().x * RotationSpeed;

            Vector3 RotationAmount = new Vector3(RotationX, RotationY, 0);

            this.gameObject.transform.Rotate(RotationAmount, Space.Self);
        }
    }
    
    void Start()
    {
        RotationCubePrev = this.transform.rotation;
        Camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
        if (Camera == null)
        {
            Debug.LogError("Camera not founded");
        }
    }

    void Update()
    {
        if (_touchManager.Touch1.TouchState.ReadValue<float>() == 1 &&
            _touchManager.Touch2.TouchState.ReadValue<float>() == 0) IsTouching = true;
        else IsTouching = false;
        
        //for rotating with camera axes, by rotating shell, what has same axes as camera, because looking at camera
        RotationCubePrev = Cube.rotation;
        RotationShellPrev = this.transform.rotation;
        this.transform.LookAt(Camera);
        RotationShellDiff = this.transform.rotation * Quaternion.Inverse(RotationShellPrev);
        Cube.rotation = Quaternion.Inverse(RotationShellDiff) * RotationCubePrev;
        ProceedRotation();
        RotationCubePrev = Cube.rotation;
        this.transform.LookAt(Camera);
        Cube.rotation = RotationCubePrev;
    }
}
