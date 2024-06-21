using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suraimu : MonoBehaviour
{

    Rigidbody2D _rb;
    [SerializeField] float _moveSpead = 2f;
    [SerializeField] float _jampPawer = 2f;
    // Start is called before the first frame update
    bool _isGrounded = true;
    AudioSource _audioSource;
    void Start()
    {
         _audioSource = GetComponent<AudioSource>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        int d = 0;
        int j = 0;
        if (Input.GetKey(KeyCode.D))
        {
            d = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            d = -1;
        }
        if (Input.GetKey(KeyCode.Space) && _isGrounded)
        {
            j = 1;
        _rb.AddForce(new Vector2( 0,j * _jampPawer), ForceMode2D.Impulse);
            _isGrounded = false;
            _audioSource.Play();
        }

        _rb.AddForce(new Vector2(d * _moveSpead * Time.deltaTime, 0), ForceMode2D.Force);
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "wase")
        {
            _isGrounded = true;
        }
    }
}


