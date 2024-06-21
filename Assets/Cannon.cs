using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    /// <summary>
    /// ‹…‚Ì”­ŽË‚ÌŒü‚«
    /// </summary>
    [SerializeField] private Vector2 _bulletDir;

    [SerializeField] private GameObject _bullet;

    [SerializeField] private float _firingInterval;

    float _elapsedTime = 0;

    public Vector2 BulletDir
    {
        get;
        set;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        var v = new Vector3(_bulletDir.x, _bulletDir.y, 0);
        Gizmos.DrawLine(transform.position, transform.position + v);
    }

    // Start is called before the first frame update
    void Start()
    {

        //Instantiate(tama2,        transform.position,       Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        _elapsedTime += Time.deltaTime;
        Debug.Log($" Œo‰ßŽžŠÔ {_elapsedTime}");

        if (_elapsedTime > _firingInterval)
        {
            var obj = Instantiate(_bullet);
            if (obj.TryGetComponent<Bullet>(out var bullet))
            {
                bullet.SetOrientation(_bulletDir);
            }

            _elapsedTime = 0;
        }
    }
}
