using UnityEngine;

public class Scaling : MonoBehaviour
{
    public float minScale = 0.5f;
    public float maxScale = 3.0f;
    public float sensitivity = 0.01f; 

    private float initialDistance;
    private Vector3 initialScale;

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touch0 = Input.GetTouch(0);
            Touch touch1 = Input.GetTouch(1);

            if (touch0.phase == TouchPhase.Began || touch1.phase == TouchPhase.Began)
            {
                initialDistance = Vector2.Distance(touch0.position, touch1.position);
                initialScale = transform.localScale;
            }
            else if (touch0.phase == TouchPhase.Moved || touch1.phase == TouchPhase.Moved)
            {
                float currentDistance = Vector2.Distance(touch0.position, touch1.position);
                float factor = currentDistance / initialDistance;

                // Вычисляем новый масштаб и ограничиваем его
                Vector3 newScale = initialScale * factor;
                newScale = Vector3.Max(Vector3.one * minScale, newScale);
                newScale = Vector3.Min(Vector3.one * maxScale, newScale);

                transform.localScale = newScale;
            }
        }
    }
}
