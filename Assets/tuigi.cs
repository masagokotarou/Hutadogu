using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuigi : MonoBehaviour
{
    public Transform player;
    Vector3 tuigyu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tuigyu = player.position;
        tuigyu.z = -10;
        transform.position = tuigyu;
    }
}
