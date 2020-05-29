/************************
	FileName:/Scripts/Game/GamePlay/Vehicles/GroundVehicles/GroundVehicles.cs
	CreateAuthor:neo.xu
	CreateTime:5/29/2020 1:41:21 PM
	Tip:5/29/2020 1:41:21 PM
************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameWish.Game
{
    [RequireComponent(typeof(Rigidbody))]
    public class GroundVehicles : Vehicles
    {
        [SerializeField] Transform m_CenterOfMass;
        private Rigidbody m_Rigidbody;
        private Wheel[] m_Wheels;

        public float motorTorque = 100f;
        public float maxSteer = 20f;

        private void Awake()
        {
            m_Wheels = GetComponentsInChildren<Wheel>();
            m_Rigidbody = GetComponent<Rigidbody>();
            m_Rigidbody.centerOfMass = m_CenterOfMass.transform.localPosition;
        }

        private void Update()
        {
            foreach (var wheel in m_Wheels)
            {
                wheel.SteerAngle = InputMgr.S.HorizontalInput * maxSteer;
                wheel.Torque = InputMgr.S.VerticalInput * motorTorque;
            }
        }

    }

}