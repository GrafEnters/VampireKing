using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraThirdPerson : MonoBehaviour {
    private const float YMin = -50.0f;
    private const float YMax = 50.0f;

    public Transform lookAt;

    public Transform Player;

    public float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    public float HorizontalSensivity = 4.0f;
    public float Verticalsensivity = 4.0f;
    public Vector3 Shift ;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void LateUpdate() {
        currentX += Input.GetAxis("Mouse X") * HorizontalSensivity * Time.deltaTime;
        currentY += Input.GetAxis("Mouse Y") * Verticalsensivity * Time.deltaTime;

        currentY = Mathf.Clamp(currentY, YMin, YMax);

        Vector3 Direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = Shift + lookAt.position + rotation * Direction;

        transform.LookAt(Shift+ lookAt.position);
    }
}