using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByTime : Despawn
{
    [SerializeField] protected float timeLimit = 10f;
    [SerializeField] protected float time = 0f;

    protected override void LoadComponents()
    {
        this.LoadTime();
    }
    protected virtual void LoadTime()
    {
        this.time = 0f;
    }

    protected override bool CanDespawn()
    {
        this.time += Time.deltaTime;
        if(this.time > this.timeLimit) return true;
        return false;
    }
}
