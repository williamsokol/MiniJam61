using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public int enemyHp;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.tag == "Wepon"){
            TakeDmg();
        }
    }

   
    public void TakeDmg()
    {
        enemyHp--;
        // do some little red flicker of dmg also
        print("enemyhurt");
        if(enemyHp <= 0){
            Die();
        }
    }
    void Die(){
        //die idk
        print("ded");

        Destroy(gameObject);
    }
}
