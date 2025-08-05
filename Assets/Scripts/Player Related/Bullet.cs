using UnityEngine;

public class Bullet : MonoBehaviour {
 
    public float speed = 20f;
    public int damage = 10;
    public Rigidbody2D rb;
    private void Start() {
        rb.velocity = transform.right * speed;
    }
    
    void OnTriggerEnter2D (Collider2D collision)
    {
        EnemyPatrol enemy = collision.GetComponent<EnemyPatrol>();
        if (enemy != null){
            enemy.TakeDamage(damage);
        }   
        Destroy(gameObject);
    }
}