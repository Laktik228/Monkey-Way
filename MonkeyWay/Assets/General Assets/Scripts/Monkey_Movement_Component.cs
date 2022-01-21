using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey_Movement_Component : MonoBehaviour
{
    // Start is called before the first frame update
    public float jumpHeight = 0.0f;
    public float climbSpeed = 0.0f;
    private bool hasCollided = false;
    private bool jumping = false;
    private Rigidbody2D _rigidBody2D;
    private string side;
    private SpriteRenderer monkeySprite;

    void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
        monkeySprite = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate() {
        if(hasCollided){
            _rigidBody2D.AddForce(Vector2.up * climbSpeed, ForceMode2D.Impulse);
        }
    }

    private void Update() {
        if(Input.GetKeyDown("space")){
            monkeySprite.flipX = !monkeySprite.flipX;
            hasCollided = false;
            jumping = true;
            if(side == "right"){
                _rigidBody2D.AddForce(Vector2.up * jumpHeight + Vector2.left * jumpHeight, ForceMode2D.Impulse);
            }
            else{
                _rigidBody2D.AddForce(Vector2.up * jumpHeight + Vector2.right * jumpHeight, ForceMode2D.Impulse);
            }
         }
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Right_Lianas" || other.gameObject.tag == "Left_Lianas"){
            hasCollided = true;
        }
        jumping = false;
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Right_Lianas" || other.gameObject.tag == "Left_Lianas"){
            hasCollided = true;
            side = other.gameObject.tag == "Right_Lianas" ? "right" : "left";
        }
        jumping = false;
    }
    void OnTriggerExit2D(Collider2D col){
        hasCollided = false;
        jumping = true;
    }
}
