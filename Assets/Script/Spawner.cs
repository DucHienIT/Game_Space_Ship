using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] protected List<Transform> prefabs;

    protected void Reset()
    {
        this.LoadComponents();
    }

    protected virtual void LoadComponents()
    {
        this.LoadPrefabs();
    }

    protected virtual void LoadPrefabs()
    {
        Transform prefabObj = this.transform.Find("Prefabs");
        foreach (Transform child in prefabObj)
        {
            this.prefabs.Add(child);
        }
        this.HidePrefabs();
    }
    protected virtual void HidePrefabs()
    {
        foreach (Transform child in this.prefabs)
        {
            child.gameObject.SetActive(false);
        }
    }
}
