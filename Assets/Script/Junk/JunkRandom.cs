using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : DucHienMonoBehaviour
{
    [SerializeField] protected JunkSpawnCtrl junkCtrl;
    

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkCtrl();
    }
    protected virtual void LoadJunkCtrl()
    {
        if(this.junkCtrl != null) return;
        this.junkCtrl = this.GetComponent<JunkSpawnCtrl>();
        Debug.Log(transform.name + " load junkCtrl", gameObject);
    }
    
    protected override void Start()
    {
        this.JunkSpawning();
    }
    protected virtual void JunkSpawning()
    {
        Transform randomPoint = this.junkCtrl.JunkSpawnPoints.GetRandomPoint();
        Transform obj = this.junkCtrl.JunkSpawner.Spawn(JunkSpawner.meteorOne, randomPoint.position, transform.rotation);
        Invoke(nameof(this.JunkSpawning), 1f);
        obj.gameObject.SetActive(true);
    }

}
