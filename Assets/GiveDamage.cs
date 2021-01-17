using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDamage : MonoBehaviour
{
    public GameObject m;
    public enemy s;

    void OnTriggerEnter2D(Collider2D col)
    {
        m = col.gameObject;
        if(m.tag == "Enemy")
        {
            s = m.GetComponent<enemy>();
            s.currentHp -= 10f;
            Destroy(gameObject);
        }
    }
}
