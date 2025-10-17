using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 0.5f;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float rotationX = touch.deltaPosition.y * rotationSpeed;
                float rotationY = -touch.deltaPosition.x * rotationSpeed;

                Vector3 rotationAmount = new Vector3(rotationX, rotationY, 0);
                
                transform.Rotate(rotationAmount, Space.World);
            }
        }
    }
}
