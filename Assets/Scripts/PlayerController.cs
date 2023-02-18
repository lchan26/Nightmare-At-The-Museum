using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            // move up
            dir += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            // move down
            dir += Vector3.back;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            // move left
            dir += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            // move right
            dir += Vector3.right;
        }
        gameObject.GetComponent<Rigidbody>().velocity = speed * dir.normalized;
    }

    void OnTriggerStay(Collider other) 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(other.gameObject);
        }
    }
}
