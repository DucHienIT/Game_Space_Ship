using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnRandom : DucHienMonoBehaviour
{
    [Header("Junk Despawn Radom")]

    [SerializeField] protected JunkSpawnCtrl junkSpawnCtrl;
    [SerializeField] protected float junkSpawnDelay = 1f;
    [SerializeField] protected float junkSpawnTimer = 0f;
    [SerializeField] protected int junkSpawnLimit = 9;


    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawnCtrl();
    }
    protected virtual void LoadJunkSpawnCtrl()
    {
        if(this.junkSpawnCtrl != null) return;
        this.junkSpawnCtrl = this.GetComponent<JunkSpawnCtrl>();
        Debug.Log(transform.name + " load junkCtrl", gameObject);
    }
    
    protected override void Start()
    {
        //this.JunkSpawning();
    }
    protected virtual void FixedUpdate()
    {
        this.JunkSpawning();
    }    
    protected virtual void JunkSpawning()
    {
        if (this.RandomReachLimit()) return;

        this.junkSpawnTimer += Time.fixedDeltaTime;
        if (this.junkSpawnTimer < this.junkSpawnDelay) return;
        this.junkSpawnTimer = 0f;

        Transform prefab = this.junkSpawnCtrl.JunkSpawner.RandomPrefab();


        Transform randomPoint = this.junkSpawnCtrl.JunkSpawnPoints.GetRandomPoint();
        Vector3 pos = randomPoint.position;
        Transform obj = this.junkSpawnCtrl.JunkSpawner.Spawn(prefab, pos, transform.rotation);
        obj.gameObject.SetActive(true);
    }
    protected virtual bool RandomReachLimit()
    {
        int currentJunk = this.junkSpawnCtrl.JunkSpawner.SpawnedCount;

        return currentJunk >= this.junkSpawnLimit;
    }    
}
