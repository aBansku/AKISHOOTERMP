using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float sensivity = 800f;

    public Transform playerBody;

    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensivity * Time.deltaTime;

        xRotation -= mouseY;

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
}