using PONG.Game.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PONG.Game.Pad
{
    public class BotPad : PadBase
    {           
        // Update is called once per frame
        void Update()
        {
            Ball closest = FindClosestBall();
            Move(closest.transform.position.y - transform.position.y);

        }

        Ball FindClosestBall()
        {
            float distance = float.PositiveInfinity;
            Ball closest = null;
            GameManager.Instance.ballList.ForEach(ball => {
                float currentDistance = Vector2.Distance(transform.position, ball.transform.position);
                if (currentDistance < distance)
                {
                    distance = currentDistance;
                    closest = ball;
                }               
            });
            return closest;
        }
    }
}

