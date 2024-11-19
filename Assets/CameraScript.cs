using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Объект, вокруг которого будет вращаться камера
    public float rotationSpeed = 5.0f; // Скорость вращения камеры

    [SerializeField]
    float scrollSpeed = 10f;
    [SerializeField]
    int maxdistance = 10;
    [SerializeField]
    int mindistance = 3;


    private Vector3 lastMousePosition;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            lastMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
            Vector3 delta = Input.mousePosition - lastMousePosition;

            float rotationX = delta.x * rotationSpeed * Time.deltaTime;
            float rotationY = -delta.y * rotationSpeed * Time.deltaTime;

            transform.RotateAround(target.position, Vector3.up, rotationX);
            transform.RotateAround(target.position, transform.right, rotationY);

            lastMousePosition = Input.mousePosition;
        }

        float z = Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
        if (z != 0)
        {
            Vector3 newpos = transform.position + transform.TransformDirection(Vector3.forward * z);
            if (ControlDistance(Vector3.Distance(newpos, target.position))) transform.position = newpos;
        }
    }

    bool ControlDistance(float distance)
    {
        if (distance > mindistance && distance < maxdistance) return true;
        return false;
    }

}
