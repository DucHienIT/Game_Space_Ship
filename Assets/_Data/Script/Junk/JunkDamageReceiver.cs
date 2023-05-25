using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDamageReceiver : DamageReceiver
{
    [Header("Junk")]
    [SerializeField] protected JunkCtrl junkCtrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkCtrl();
    }

    protected virtual void LoadJunkCtrl()
    {
        if (this.junkCtrl != null) return;
        this.junkCtrl = transform.parent.GetComponent<JunkCtrl>();

        Debug.Log(transform.name + ": LoadJunkCtrl", gameObject);
    }
    protected override void OnDead()
    {
        this.junkCtrl.JunkDespawn.DespawnObject();
        this.OnDeadFX();
    }
    protected virtual void OnDeadFX()
    {
        string fxName = this.GetOnDeadFXName();
        Transform fxOnDead = FXSpawner.Instance.Spawn(fxName, transform.position, transform.rotation);
        fxOnDead.gameObject.SetActive(true);

    }    
    protected virtual string GetOnDeadFXName()
    {
        return FXSpawner.smokeOne;
    }
    public override void Reborn()
    {
        this.maxHp = this.junkCtrl.JunkSO.hpMax;
        base.Reborn();
    }
}
