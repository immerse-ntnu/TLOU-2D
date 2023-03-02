using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TLOU2D.game {
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D _body;
        private BoxCollider2D _col;

        [SerializeField] private int health = 100;
        [SerializeField] private float movementSpeed = 7f;

        void Start()
        {
            _body = GetComponent<Rigidbody2D>();
            _col = GetComponent<BoxCollider2D>();
        }

        void FixedUpdate()
        {
            float dirX = Input.GetAxisRaw("Horizontal");
            float dirY = Input.GetAxisRaw("Vertical");
            _body.velocity = new Vector2(dirX * movementSpeed, _body.velocity.y);
            _body.velocity = new Vector2( _body.velocity.x, dirY * movementSpeed); 
        }
        
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.CompareTag("EnemyTest"))
            {
                health -= 10;
                Debug.Log(health);

            }
        }
    }
    
    }
