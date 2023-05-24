using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : DucHienMonoBehaviour
{
    [SerializeField] protected Transform model;
    public Transform Model { get { return model; } }

    [SerializeField] protected DamageReceiver damageReceiver;
    public DamageReceiver DamageReceiver { get { return damageReceiver; } }

    [SerializeField] protected JunkDespawn junkDespawn;
    public JunkDespawn JunkDespawn { get => junkDespawn; }


    [SerializeField] protected JunkSO junkSO;
    public JunkSO JunkSO { get => junkSO; }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
        this.LoadDamageReceiver();
        this.LoadJunkDespawn();
        this.LoadJunkSO();
    }
    protected virtual void LoadModel()
    {
        if (this.model != null) return;
        this.model = transform.Find("Model");
        Debug.Log("LoadModel: " + this.model);
    }
    protected virtual void LoadJunkSO()
    {
        if (this.JunkSO != null) return;
        string resPath = "Junk/" + transform.name;
        this.junkSO = Resources.Load<JunkSO>(resPath);
        Debug.LogWarning(transform.name + ": LoadJunkSO" + resPath, gameObject);
    }
    protected virtual void LoadDamageReceiver()
    {
        if (this.damageReceiver != null) return;
        this.damageReceiver = GetComponentInChildren<DamageReceiver>();
        Debug.Log("LoadDamageReceiver: " + this.damageReceiver);
    }
    protected virtual void LoadJunkDespawn()
    {
        if(this.junkDespawn != null) return;
        this.junkDespawn = GetComponentInChildren<JunkDespawn>();
    }
}
