using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PONG.Game.Pad
{
    public class PlayerPad : PadBase
    {
        [SerializeField]
        private string axis = "Vertical";
        
        // Update is called once per frame
        void Update()
        {
            float vertical = Input.GetAxis(axis);
            Move(vertical);         
        }
    }
}

