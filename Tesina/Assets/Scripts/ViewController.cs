using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour
{
    //Describes which directions this script should control
    [Flags]
    public enum RotationDirection{
        None,
        Horizontal = (1 << 0),
        Vertical = (1 << 1)
    }

    [Tooltip("Which directions this object can rotate")]
    [SerializeField] private RotationDirection rotationDirections;
    [Tooltip("The rotation acceleration, in degrees / second")]
    [SerializeField] private Vector2 acceleration;
    [Tooltip("A multiplier to the input: Describes the maximum speed in degrees / second")]
    [SerializeField] private Vector2 sensitivity;
    [Tooltip("The period to wait until resetting the input value. Set as low as possible, without stuttering")]
    [SerializeField] private float inputLagPeriod;
    [Tooltip("Max angle to rotate")]
    [SerializeField] private float maxVerticalAngleFromHorizon;

    private Vector2 rotation; //Rotation in degrees
    private Vector2 velocity; //The current velocity, in degrees
    private Vector2 lastInputEvent; // The last recieved non 0 input
    private float inputLagTimer; // The time since the last recieved non 0 input

    private float ClampVerticalAngle(float angle){
        return Mathf.Clamp(angle, -maxVerticalAngleFromHorizon, maxVerticalAngleFromHorizon);
    }

    private Vector2 GetInput(){
        inputLagTimer += Time.deltaTime;
        //Get the input vector
        Vector2 input = new Vector2(
            Input.GetAxis("Mouse X"),
            Input.GetAxis("Mouse Y")
        );

        if((Mathf.Approximately(0,input.x) && Mathf.Approximately(0, input.y)) == false || inputLagTimer >= inputLagPeriod){
            lastInputEvent = input;
            inputLagTimer = 0;
        }

        return lastInputEvent;
    }

    private void Update(){
        Vector2 wantedVelocity = GetInput() * sensitivity;

        //Xero out the wanted velocity if this controller doesn't rotate in that direction
        if((rotationDirections & RotationDirection.Horizontal) == 0){
            wantedVelocity.x = 0;
        }
        if((rotationDirections & RotationDirection.Vertical) == 0){
            wantedVelocity.y = 0;
        }

        //Calculate new rotation
        velocity = new Vector2(
            Mathf.MoveTowards(velocity.x, wantedVelocity.x, acceleration.x * Time.deltaTime),
            Mathf.MoveTowards(velocity.y, wantedVelocity.y, acceleration.y * Time.deltaTime)
        );
        rotation += velocity * Time.deltaTime;
        rotation.y = ClampVerticalAngle(rotation.y);

        //Convert rotation to euler angles
        transform.localEulerAngles = new Vector3(rotation.y, rotation.x, 0);
    }
}
