using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int crush;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == ("Player"))

        {

            collision.gameObject.GetComponent<PlayerHealth>().DoDamage(crush);
            Destroy(gameObject);

        }

    }
}
