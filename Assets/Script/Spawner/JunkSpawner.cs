using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    private static JunkSpawner instance;
    public static JunkSpawner Instance { get { return instance; } }

    public static string meteorOne = "Meteor_01";

    protected override void Awake()
    {
        base.Awake();
        if(JunkSpawner.instance != null) Debug.LogError("There are more than one JunkSpawner in the scene!");
        JunkSpawner.instance = this;
    }
}
