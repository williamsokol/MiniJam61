using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHp : MonoBehaviour
{
    public static PlayerHp instance;
    public GameObject player;

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
        if(_hp <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    void Awake(){
        instance = this;
    }

    private void Update()
    {
        if(player.transform.position.y <= -20)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
