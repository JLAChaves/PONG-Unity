using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PONG.Game.Utils
{
    public static class RandomUtils
    {
        public static bool RandomBool()
        {
            return Random.Range(0, 100) > 50;
        }
    }
}

