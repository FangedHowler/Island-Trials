using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleporterLavaCave : Teleporters
{
    public override void Teleport()
    {
        base.Teleport();

        SceneManager.LoadScene(2);
    }
}
