using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    Vector2 oldDirection =  new Vector2(0,0);
    public GameObject projectile, shootSpot;
    public float timer = 0, attackSpeed;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateAttackBox();
        ShowWepon();
    }

    void RotateAttackBox(){

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 dirction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        float angle = Mathf.Atan2(dirction.y, dirction.x) * Mathf.Rad2Deg;
        Vector3 vec = new Vector3(0,0,(Mathf.Round(angle/45)*45)-90);

        transform.eulerAngles = vec;
    }

    void ShowWepon(){

        if(Input.GetButton("Fire1") && timer >= attackSpeed){
            //dmgBox.SetActive(true);
            Instantiate(projectile, shootSpot.transform.position, transform.rotation);
            timer = 0;
        }else{
            //dmgBox.SetActive(false);
            timer += Time.deltaTime;   
        }
    }
}
