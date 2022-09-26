using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public float mouseSensivity = 100f;
    public Transform playerBody;
    float xROtation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mousX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouaeY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;
        xROtation -= mouaeY;
        xROtation = Mathf.Clamp(xROtation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xROtation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mousX);
              
    }
}
