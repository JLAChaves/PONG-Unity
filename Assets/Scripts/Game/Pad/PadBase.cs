using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PONG.Game.Pad
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class PadBase : MonoBehaviour
    {
        [SerializeField]
        [Min(0f)]
        private float speed = 5;

        private Rigidbody2D _body;


        // Start is called before the first frame update
        protected virtual void Start()
        {
            _body = GetComponent<Rigidbody2D>();
        }

        protected void Move(float move)
        {
            if (move == 0)
            {
                _body.velocity = Vector2.zero;
            }
            else
            {
                _body.velocity = new Vector2(0, Mathf.Sign(move)) * speed;
            }            
        }

    }
}

