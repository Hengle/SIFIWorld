/************************
	FileName:/Scripts/Game/GamePlay/Vehicles/GroundVehicles/Wheel.cs
	CreateAuthor:neo.xu
	CreateTime:5/29/2020 2:09:42 PM
	Tip:5/29/2020 2:09:42 PM
************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameWish.Game
{
    public class Wheel : MonoBehaviour
    {
        [SerializeField] private bool steer;
        [SerializeField] private bool invertSteer;
        [SerializeField] private bool power;

        public float SteerAngle { get; set; }
        public float Torque { get; set; }


        private WheelCollider wheelCollider;
        private Transform wheelTransform;

        private void Start()
        {
            wheelCollider = GetComponent<WheelCollider>();
            wheelTransform = GetComponentInChildren<MeshRenderer>().transform;
        }

        private void Update()
        {
            wheelCollider.GetWorldPose(out Vector3 pos, out Quaternion rot);
            wheelTransform.position = pos;
            wheelTransform.rotation = rot;//* Quaternion.Euler(0, 0, 0);
        }

        private void FixedUpdate()
        {
            if (steer)
            {
                wheelCollider.steerAngle = SteerAngle * (invertSteer ? -1 : 1);
            }

            if (power)
            {
                wheelCollider.motorTorque = Torque;
            }
        }


    }

}