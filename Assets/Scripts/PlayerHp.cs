using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public static PlayerHp instance;

    [SerializeField]
    private float _hp;

    //updates on hp variable being changed
    public float hp{
        get{return _hp;}

        set{
            _hp = value;
            UpdateHp();
        }
    }
    public void UpdateHp(){
        // modify hp indicator
        HpUI.instance.LoseHp((int)_hp);
        if(_hp <= 0){
            //dead stuff
            print("game over");
        }
    }

    void Awake(){
        instance = this;
    }

    
}
