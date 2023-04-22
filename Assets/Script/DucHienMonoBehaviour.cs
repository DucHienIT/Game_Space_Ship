using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DucHienMonoBehaviour : MonoBehaviour
{
    protected virtual void Start()
    {
        this.LoadComponents();
    }

    protected virtual void Reset()
    {
        this.LoadComponents();
    }
    protected virtual void Awake()
    {
        this.LoadComponents();
    }

    protected virtual void LoadComponents()
    {
        
    }

}