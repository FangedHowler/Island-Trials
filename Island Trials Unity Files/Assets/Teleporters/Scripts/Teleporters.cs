using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporters : MonoBehaviour
{


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            if (Input.GetButtonDown("Fire3"))
            {
                Teleport();
            }
        }
    }

    public virtual void Teleport()
    {
        print("teleported");
    }
}
