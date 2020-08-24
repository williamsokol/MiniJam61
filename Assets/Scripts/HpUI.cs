using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpUI : MonoBehaviour
{
    public static HpUI instance;
    public Image[] eyes;
    public Sprite empty;
   
   void Awake(){
       instance = this;
   }
    public void LoseHp(int eye){
        if(eye > -1){
            eyes[eye].sprite = empty;
        }
        print(eye);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
