using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float maxHp = 0f;
    public float currentHp = 0f;
    //variables


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHp > maxHp)
        {
            currentHp = maxHp;
        }
        if(currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
