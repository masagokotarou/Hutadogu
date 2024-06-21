using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 球の移動をする機能を提供する
/// </summary>
public class Bullet : MonoBehaviour
{
    Rigidbody2D _rb2d;

    Vector2 _direction = Vector2.up * 5f;

    /// <summary>
    /// 向きを指定する
    /// </summary>
    public void SetOrientation(Vector2 vec)
    {
        this.transform.up = vec;
    }

    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _rb2d.velocity = _rb2d.transform.up;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}
