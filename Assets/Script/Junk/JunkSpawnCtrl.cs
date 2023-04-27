using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnCtrl : DucHienMonoBehaviour
{
    [SerializeField] protected JunkSpawner junkSpawner;
    [SerializeField] protected JunkSpawnPoints junkSpawnPoints;

    public JunkSpawner JunkSpawner { get { return junkSpawner; } }
    public JunkSpawnPoints JunkSpawnPoints { get { return junkSpawnPoints; } }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawner();
        this.LoadJunkSpawnPoints();
    }
    protected virtual void LoadJunkSpawner()
    {
        if(this.junkSpawner != null) return;
        this.junkSpawner = this.GetComponent<JunkSpawner>();
        Debug.Log(transform.name + " load junkSpawner", gameObject);
    }

    protected virtual void LoadJunkSpawnPoints()
    {
        if(this.junkSpawnPoints != null) return;
        this.junkSpawnPoints = Transform.FindObjectOfType<JunkSpawnPoints>();
        Debug.Log(transform.name + " load JunkSpawnPoints", gameObject);
    }

}
