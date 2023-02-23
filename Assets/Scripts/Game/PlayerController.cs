using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TLOU2D.game {
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D _body;
    
        [SerializeField] private float movementSpeed = 7f;

        void Start()
        {
            _body = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            float dirX = Input.GetAxisRaw("Horizontal");
            float dirY = Input.GetAxisRaw("Vertical");
            _body.velocity = new Vector2(dirX * movementSpeed, _body.velocity.y);
            _body.velocity = new Vector2( _body.velocity.x, dirY * movementSpeed); 
        }
    }
}