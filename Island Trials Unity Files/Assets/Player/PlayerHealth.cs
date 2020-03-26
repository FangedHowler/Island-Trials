using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    Renderer rend;

    public void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.SetColor("_Color", Color.white);
    }

    public void DoDamage(int damageToDo)
    {
        rend.material.SetColor("_Color", Color.red);
        Invoke("ReturnColor", 0.1f);

        health -= damageToDo;
        if (health <= 0)
        {

            SceneManager.LoadScene(0);

        }
    }

    public void ReturnColor()
    {
        rend.material.SetColor("_Color", Color.white);
    }
}
