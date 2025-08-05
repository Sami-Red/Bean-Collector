using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    

    private void OnCollisionEnter2D(Collision2D collisoin) {
        if(collisoin.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
            LevelManager.instance.Respawn();
        }
    }
    






}
