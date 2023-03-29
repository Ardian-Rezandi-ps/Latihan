using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        public float speed;
         public VariableJoystick variableJoystick;
        private Animator animator;

        public Collider2D colliderPlayer;
        private void Start()
        {
            animator = GetComponent<Animator>();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.tag=="npc"){
               // DialogKita.instance.BicarasamaNpcBurung();
            }
        }
        
        private void FixedUpdate()
        {

            animator.SetFloat("movX",variableJoystick.Horizontal);
            animator.SetFloat("movY",variableJoystick.Vertical);
            Vector2 joystikV2= new Vector2(variableJoystick.Horizontal,variableJoystick.Vertical);
            animator.SetFloat("speed",joystikV2.sqrMagnitude);
             GetComponent<Rigidbody2D>().velocity = speed * joystikV2;
           // Vector2 dir = Vector2.zero;
           /* if (Input.GetKey(KeyCode.A))
            {
                dir.x = -1;
                animator.SetInteger("Direction", 3);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = 1;
                animator.SetInteger("Direction", 2);
            }

            if (Input.GetKey(KeyCode.W))
            {
                dir.y = 1;
                animator.SetInteger("Direction", 1);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;
                animator.SetInteger("Direction", 0);
            }
                
//            print("X="+variableJoystick.Horizontal+"|| Y="+variableJoystick.Vertical) ;
          float arahY=0;
          float arahX=0;
           //  print("X="+arahX+"|| Y="+arahY) ;
          

            if (variableJoystick.Vertical>0)
            {
               dir.y= 1;
            
            }
            else if (variableJoystick.Vertical<0)
            {
                dir.y= -1;
        
            }else{
                  dir.y= 0;
               
            }
              if (variableJoystick.Horizontal<0)
            {
              dir.x = -1;
          
            }
            else if (variableJoystick.Horizontal>0)
            {
                dir.x = 1;
           
            }else{
                 dir.x =0;
               
            }
             animator.SetFloat("movX",dir.x);
                animator.SetFloat("movY",dir.y);
            dir.Normalize();
            animator.SetBool("IsMoving", dir.magnitude > 0);

            GetComponent<Rigidbody2D>().velocity = speed * dir;
            */
        }
    }
}
