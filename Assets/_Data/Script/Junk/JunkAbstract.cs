using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkAbstract : DucHienMonoBehaviour
{
    [SerializeField] protected JunkCtrl junkCtrl;
    public JunkCtrl JunkCtrl { get { return junkCtrl; } }

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkCtrl();
    }
    protected virtual void LoadJunkCtrl()
    {
        if (this.junkCtrl != null) return;
        this.junkCtrl = transform.parent.GetComponent<JunkCtrl>();
        Debug.Log("LoadJunkCtrl: " + this.junkCtrl);
    }
}
