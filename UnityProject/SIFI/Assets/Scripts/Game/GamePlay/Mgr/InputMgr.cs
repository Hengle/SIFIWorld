/************************
	FileName:/Scripts/Game/GamePlay/Mgr/InputMgr.cs
	CreateAuthor:neo.xu
	CreateTime:5/29/2020 3:31:20 PM
	Tip:5/29/2020 3:31:20 PM
************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GFrame;


namespace GameWish.Game
{
    public class InputMgr : TMonoSingleton<InputMgr>
    {
        public const string Axis_Vertical = "Vertical";
        public const string Axis_Horizontal = "Horizontal";


        public float VerticalInput { get; private set; }
        public float HorizontalInput { get; private set; }

        private bool m_CanInput = true;

        private void Update()
        {
            if (!m_CanInput) return;

            VerticalInput = Input.GetAxis(Axis_Vertical);
            HorizontalInput = Input.GetAxis(Axis_Horizontal);
        }
    }

}