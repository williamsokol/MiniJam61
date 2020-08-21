using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public float speed;
    public Transform PatrolBlockLeft;
    public Transform PatrolBlockRight;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if(transform.position.x >= PatrolBlockRight.position.x || transform.position.x <= PatrolBlockLeft.position.x)
        {
            speed = -speed;
        }
    }
}