using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float xSpeed = 0f;
    public float ySpeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (transform.position + new Vector3(xSpeed, ySpeed, 0));
    }
}
