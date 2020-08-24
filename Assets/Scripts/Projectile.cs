using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;
    public Animator animator;
    private float timer = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.up * moveSpeed,Space.Self);
    }
    void Update(){
        timer += Time.deltaTime;
        if(timer > 1f){
            animator.SetTrigger("Hit");
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        
        if(other.tag == "Enemy"){
            //print("good");
            FadeOut();
        }
    }

    public void FadeOut(){
        //print("fadeout");
        animator.SetTrigger("Hit");
    }
    void Die(){
        Destroy(gameObject);
    }
}
