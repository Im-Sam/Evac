using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAt : MonoBehaviour
{
    public Transform playerTransform;
    public float mouseSpeed;
    float xRoation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;

        playerTransform.Rotate(Vector3.up * mouseX);

        xRoation -= mouseY;
        xRoation = Mathf.Clamp(xRoation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRoation, 0f, 0f);
    }
}
