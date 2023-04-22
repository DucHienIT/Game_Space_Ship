using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected bool shooting = false;
    [SerializeField] protected float shootDelay = 0.5f;
    [SerializeField] protected float shootTimer = 0f;
    [SerializeField] protected Transform bulletPrefab;
    
    void Update()
    {
        this.SetShooting();
        //this.Shoot();
    }
    void FixedUpdate()
    {
        this.Shoot();
    }

    protected virtual void Shoot()
    {
        if(!this.shooting) return;

        this.shootTimer += Time.fixedDeltaTime;
        if(this.shootTimer < this.shootDelay) return;
        this.shootTimer = 0f;

        Vector3 spawnPos = transform.position;
        Quaternion rotation = transform.parent.rotation;
        Instantiate(this.bulletPrefab, spawnPos, rotation);

    }
    protected virtual void SetShooting()
    {
        this.shooting = InputManager.Instance.OnFiring == 1;
    }

}
