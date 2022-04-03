using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StupidRaceCar : BaseSteeringBehavior {
    [SerializeField] Track _track;
    int _trackCheckPointIndex;
    Vector3 _targetPosition;

    public float targetRadius = 3.0f;
    public float slowRadius = 10.0f;
    public float maxSpeed = 10.0f;


    public override SteeringOutput GetSteering()
    {
        SteeringOutput steering;
        steering.linear = Vector3.zero;
        steering.angular = 0;

        _targetPosition = _track.GetCheckPointAtClamped(_trackCheckPointIndex).position;
        Vector3 direction = _targetPosition - character.transform.position;
        direction.y = 0;
        float distance = direction.magnitude;

        if (distance < targetRadius) {
            _trackCheckPointIndex++;
            return steering;
        }

        float targetSpeed = 0;
        if (distance > slowRadius)
        {
            targetSpeed = maxSpeed;
        }

        Vector3 targetVelocity = direction;
        targetVelocity.Normalize();
        targetVelocity *= targetSpeed;

        steering.linear = targetVelocity - character.velocity;
        steering.linear.y = 0;

        return steering;
    }
}
