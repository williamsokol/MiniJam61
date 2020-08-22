using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDmg : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other){
       
       if(other.tag == "Player"){
           
           PlayerHp.instance.hp--;
       }
   }
}
