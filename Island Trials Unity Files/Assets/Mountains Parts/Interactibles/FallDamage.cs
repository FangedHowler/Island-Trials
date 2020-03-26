using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
    public int falling;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == ("Player"))

        {

            collision.gameObject.GetComponent<PlayerHealth>().DoDamage(falling);
        }

    }
}
