using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yuka : MonoBehaviour
{
    //float poruno = Time.deltaTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + Time.deltaTime);
        }
    }
}
