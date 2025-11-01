using System;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    private TouchManagerAPI _touchManager;
    
    [SerializeField] private float MinScale = 0.5f;
    [SerializeField] private float MaxScale = 3f;

    private float InitialDistance;
    private Vector3 InitialScale;
    private bool PrevStatus = false;
    private float initialScaleX; // Добавлено: храним начальный масштаб

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
    
    void Start()
    {
        initialScaleX = this.gameObject.transform.localScale.x;
    }

    void Update()
    {
        if (_touchManager.Touch1.TouchState.ReadValue<float>() == 1 &&
            _touchManager.Touch2.TouchState.ReadValue<float>() == 1)
        {
            Vector2 Touch1 = _touchManager.Touch1.TouchPosition.ReadValue<Vector2>();
            Vector2 Touch2 = _touchManager.Touch2.TouchPosition.ReadValue<Vector2>();
            
            if (!PrevStatus)
            {
                InitialDistance = Vector2.Distance(Touch1, Touch2);
                InitialScale = transform.localScale;
                PrevStatus = true;
            }
            else
            {
                float currentDistance = Vector2.Distance(Touch1, Touch2);
                float factor = currentDistance / InitialDistance;

                Vector3 newScale = InitialScale * factor;
                newScale.x = Mathf.Clamp(newScale.x, initialScaleX * MinScale, initialScaleX * MaxScale);
                newScale.y = Mathf.Clamp(newScale.y, initialScaleX * MinScale, initialScaleX * MaxScale);
                newScale.z = Mathf.Clamp(newScale.z, initialScaleX * MinScale, initialScaleX * MaxScale);

                transform.localScale = newScale;
            }
        }
        else
        {
            PrevStatus = false;
        }
    }
}