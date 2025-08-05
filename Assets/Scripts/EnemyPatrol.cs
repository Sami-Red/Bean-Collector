using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {
   
   [Header("Patrol Stuff")]
   public float speed = 2f;
   public Rigidbody2D rb;
   public LayerMask groundLayers;
   public Transform groundCheck;
   bool isFacingRight = true;
   RaycastHit2D hit;


    // Patrolling stuff
    private void Update() {
        hit = Physics2D.Raycast(groundCheck.position, -transform.up, 1f, groundLayers);
    }
    private void FixedUpdate() {
        if(hit.collider != false){
            if(isFacingRight){
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }else{
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
        } else{
            isFacingRight = !isFacingRight;
            transform.localScale = new Vector3(-transform.localScale.x,1f, 1f );
        }
    }   

    //take damage
    public int health = 20;
    
    public void TakeDamage(int damage){
        health -= damage;
        if (health <= 0){
            Die();
            Debug.Log("Dead");
        }
        Debug.Log("Hurt");
        
    }
    void Die(){
        Destroy(gameObject);
    }






}
