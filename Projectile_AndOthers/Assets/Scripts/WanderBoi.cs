using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderBoi : Kinematic
{
    Wander myMoveType;
    Face myRotateType;


    private void Start()
    {
        myMoveType = new Wander();
        myMoveType.character = this;
        myMoveType.target = myTarget;

        myRotateType = new Face();
        myRotateType.character = this;
        myRotateType.target = myTarget;



    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }

}
