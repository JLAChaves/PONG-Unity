using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PONG.Game.Managers
{
    public class GameManager : MonoBehaviour
    {       
        public static GameManager Instance { get; private set; }

        [SerializeField]         
        private Ball ballPrefab = null;

        [SerializeField]
        private Transform ballSpawnPosition = null;

        public List<Ball> ballList { get; private set; } = new List<Ball>();
       
        void Awake()
        {
            Instance = this;              
        }

        private void Start()
        {
            SpawnBall();
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(ballSpawnPosition.position, ballSpawnPosition.localScale.magnitude);
        }

        public void SpawnBall()
        {
            Ball ball = Instantiate(ballPrefab, ballSpawnPosition.position, Quaternion.identity);
            ballList.Add(ball);           
        }

        public void RemoveBall(Ball ball)
        {
            ballList.Remove(ball);
        }
    }
}

