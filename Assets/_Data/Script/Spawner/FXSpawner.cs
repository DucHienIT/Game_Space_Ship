using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXSpawner : Spawner
{
    private static FXSpawner instance;
    public static FXSpawner Instance { get { return instance; } }

    public static string smokeOne = "Smoke_1";

    protected override void Awake()
    {
        base.Awake();
        if(FXSpawner.instance != null) Debug.LogError("There are more than one FXSpawner in the scene!");
        FXSpawner.instance = this;
    }

}
