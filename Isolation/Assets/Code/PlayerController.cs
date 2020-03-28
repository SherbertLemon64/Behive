using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float mouseSensetivty = 3f;
    public CharacterController controller;

    public Transform cameraControl;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensetivty;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivty;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -75f, 75);
        cameraControl.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.Rotate(Vector3.up * mouseX);

        float x = Input.GetAxis("Horizontal") * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * Time.deltaTime;

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move);
    }
}
