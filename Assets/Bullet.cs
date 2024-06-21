using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ‹…‚ÌˆÚ“®‚ð‚·‚é‹@”\‚ð’ñ‹Ÿ‚·‚é
/// </summary>
public class Bullet : MonoBehaviour
{
    Rigidbody2D _rb2d;

    Vector2 _direction = Vector2.up * 5f;

    /// <summary>
    /// Œü‚«‚ðŽw’è‚·‚é
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
