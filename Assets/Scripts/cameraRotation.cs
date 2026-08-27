using UnityEngine;
using UnityEngine.InputSystem;

public class cameraRotation : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    private float xRotation = 0;

    [SerializeField]
    private float xSensitivity = 100;
    [SerializeField]
    private float ySensitivity = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.isPlaying == true)
        {
            if (Mouse.current == null) return;

            Vector2 mouseInput = Mouse.current.delta.ReadValue();
            xRotation -= mouseInput.y * ySensitivity;
            xRotation = Mathf.Clamp(xRotation, -90, 90);

            transform.Rotate(0f, mouseInput.x * xSensitivity, 0f);
            cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        }
    }
}
