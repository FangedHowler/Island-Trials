using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MountainsToHub : Teleporters
{
    public override void Teleport()
    {
        base.Teleport();

        SceneManager.LoadScene(0);
    }
}
