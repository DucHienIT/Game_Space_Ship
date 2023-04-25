using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnPoints : DucHienMonoBehaviour
{
    [SerializeField] protected List<Transform> spawnPoints;
    
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadSpawnPoints();
    }
    protected virtual void LoadSpawnPoints()
    {
        if(this.spawnPoints.Count > 0) return;
        foreach (Transform child in transform)
        {
            child.position = this.SetRandomPosition();
            this.spawnPoints.Add(child);
        }
    }
    public virtual Transform GetRandomPoint()
    {
        int randomIndex = Random.Range(0, this.spawnPoints.Count);
        return this.spawnPoints[randomIndex];
    }
    protected virtual Vector3 SetRandomPosition()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-20f, 20), Random.Range(-10, 10f), Random.Range(0f, 1f));
        return randomPosition;
    }
}
