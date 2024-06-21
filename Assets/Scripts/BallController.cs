using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] private float _PlayerSpeed;

    private Rigidbody2D _rb;
    private float _inputX;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _inputX = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        _rb.velocity = new Vector2(_inputX * _PlayerSpeed, _rb.velocity.y);
    }
}