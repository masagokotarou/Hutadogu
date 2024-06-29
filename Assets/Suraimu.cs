using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Suraimu : MonoBehaviour
{

    Rigidbody2D _rb;
    [SerializeField] float _moveSpead = 2f;
    [SerializeField] float _jampPawer = 2f;
    [SerializeField] GameObject _goalText;
    [SerializeField] Text _gameOverText;
    [SerializeField] Text _gameOverText2;
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
            transform.localScale = new Vector3(0.08417242f, 0.08515273f, 3.220528f);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            d = -1;
            transform.localScale = new Vector3(-0.08417242f, 0.08515273f, 3.220528f);
        }
        if (Input.GetKey(KeyCode.Space) && _isGrounded)
        {
            j = 1;
            _rb.AddForce(new Vector2(0, j * _jampPawer), ForceMode2D.Impulse);
            _isGrounded = false;
            _audioSource.Play();
        }
        _rb.AddForce(new Vector2(d * _moveSpead * Time.deltaTime, 0), ForceMode2D.Force);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("‚Ô‚Â‚©‚Á‚½");
        if (collision.gameObject.tag == "wase")
        {
            _isGrounded = true;
        }
        if (collision.gameObject.tag == "clear")
        {
            _goalText.gameObject.SetActive (true);
            Destroy(this.gameObject, 0.01f);
            
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GameOver" || collision.gameObject.tag == "tama2")
        {
            _gameOverText.gameObject.SetActive(true);
            _gameOverText.text = "GameOver";
            Destroy(this.gameObject, 0.01f);


        }

        if (collision.gameObject.tag == "tama2" || collision.gameObject.tag == "DeadGround")
        {
            _gameOverText.text = "GameOver";
            Destroy(this.gameObject, 0.01f);
        }
    }
}
