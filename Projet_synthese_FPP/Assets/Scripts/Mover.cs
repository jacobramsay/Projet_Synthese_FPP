using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class Mover : MonoBehaviour
    {
        private Rigidbody2D rigidBody;


        private void Start()
        {
            rigidBody = transform.root.GetComponentInParent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float speed = 10;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = 15;
            }
            else
            {
                speed = 7;
            }
            HandleMovement(horizontal, speed);
        }
        public void HandleMovement(float horizontal,float speed)
        {
            rigidBody.velocity = new Vector2(horizontal * speed, rigidBody.velocity.y);
        }
        public void move(float speed)
        {
            
        }
    }
}
