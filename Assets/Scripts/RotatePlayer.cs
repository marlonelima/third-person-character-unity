using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    public float mouseSensitivity = 2f;
    // float yRotation = 0f;
    float savedAngle = 0f;

    [SerializeField] private float _smoothTime = 0.3f;
private float _velocity = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        
        // playerBody.Rotate(Vector3.up * mouseX);
      
        transform.Rotate(0f, mouseX * mouseSensitivity, 0f);
    }

}