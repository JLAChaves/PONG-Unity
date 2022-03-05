using PONG.Game.Managers;
using PONG.Game.Utils;
using UnityEngine;

namespace PONG.Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Ball : MonoBehaviour
    {
        [SerializeField]
        [Min(0f)]
        private float speed = 5;
        [SerializeField]
        [Min(0f)]
        private float speedUp = 1.01f;

        private Vector2 velocity;
        private Rigidbody2D _body;


        // Start is called before the first frame update
        void Start()
        {
            _body = GetComponent<Rigidbody2D>();
            velocity = new Vector2(
                RandomUtils.RandomBool() ? 1 : -1,
                RandomUtils.RandomBool() ? 1 : -1
            ).normalized * speed;
        }

        // Update is called once per frame
        void Update()
        {
            _body.velocity = velocity;
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            speed *= speedUp;
            Debug.Log(collision.gameObject.name);
            Vector2 normal = collision.contacts[0].normal;
            Vector2 reflection = Vector2.Reflect(velocity.normalized, normal);
            velocity = reflection * speed;
            GameManager.Instance.SpawnBall();
        }        
    }
}


