using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleporterMountain : Teleporters
{
    public override void Teleport()
    {
        base.Teleport();

        SceneManager.LoadScene(3);
    }
}
