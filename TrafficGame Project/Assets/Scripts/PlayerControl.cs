using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    public static float SPEED { get; set; }

    private Transform VehicleTransform;
    private Vector3 baseVehicleRotate;
    public float turnSpeed = 2f;
    public float tiltAngle = 5f;
    public float tiltSmooth = 20f;
    public float acceleration = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        SPEED = 0.05f;
        VehicleTransform = GetComponent<Transform>();
        baseVehicleRotate = VehicleTransform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        VehicleTransform.position += new Vector3(Input.GetAxis("Horizontal") * turnSpeed, 0, 0);
        float titlAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        VehicleTransform.rotation = Quaternion.Slerp(VehicleTransform.rotation, Quaternion.Euler(titlAroundZ, baseVehicleRotate.y, baseVehicleRotate.z), Time.deltaTime * tiltSmooth);

        if (Input.GetAxis("Vertical") != 0) SPEED += acceleration * Input.GetAxis("Vertical") * Time.deltaTime;
        

        

    }
}
