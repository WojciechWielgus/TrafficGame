using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    
    public static float SPEED { get; set; }
    public static float DISTANCE { get; set; }

    private Transform VehicleTransform;
    private Vector3 baseVehicleRotate;
    public float turnSpeed = 2f;
    public float tiltAngle = 5f;
    public float tiltSmooth = 20f;
    public float acceleration = 0.1f;
    public float brakeSpeed = 4f;

    

    // Start is called before the first frame update
    void Start()
    {
        SPEED = 1f;
        VehicleTransform = GetComponent<Transform>();
        baseVehicleRotate = VehicleTransform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        VehicleTransform.position += new Vector3(Input.GetAxis("Horizontal") * turnSpeed, 0, 0);
        float titlAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        VehicleTransform.rotation = Quaternion.Slerp(VehicleTransform.rotation, Quaternion.Euler(titlAroundZ, baseVehicleRotate.y, baseVehicleRotate.z), Time.deltaTime * tiltSmooth);

        if (Input.GetAxis("Vertical") > 0) SPEED += Acceleration(SPEED) * Input.GetAxis("Vertical") * Time.deltaTime;
        if (Input.GetAxis("Vertical") < 0) SPEED += brakeSpeed * Input.GetAxis("Vertical") * Time.deltaTime;

        //DISTANCE += SPEED * Time.deltaTime;
        DISTANCE += SPEED;

    }

    float Acceleration(float speed)
    {
        float acceleration = 0;
        if (speed <= 3) acceleration = 1.5f;
        else if (speed > 3 && speed <= 4) acceleration = 1f;
        else if (speed > 4 && speed <= 5) acceleration = 0.6f;
        else if (speed > 5 && speed <= 7) acceleration = 0.4f;
        else if (speed > 7 && speed <= 10) acceleration = 0.2f;
        else if (speed > 10) acceleration = 0.05f;

        return acceleration;
    }
}
