using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeInteractive : MonoBehaviour
{
    public int stab;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == ("Player"))

        {

            collision.gameObject.GetComponent<PlayerHealth>().DoDamage(stab);
        }

    }
}