using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Camera : MonoBehaviour
{
    Suraimu player;
    GameObject playerObjct;
    Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        player = playerObjct.GetComponent<Suraimu>();
        playerObjct = GameObject.FindGameObjectWithTag("suraimu");
        playerTransform = playerObjct.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z);
    }
}