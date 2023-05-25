using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotate : JunkAbstract
{
    [SerializeField] protected float rotateSpeed = 9f;

    protected virtual void FixedUpdate()
    {
        this.Rotating();
    }

    protected virtual void Rotating()
    {
        Vector3 rotate = new Vector3(0, 0, 1);
        this.JunkCtrl.Model.Rotate(rotate * this.rotateSpeed * Time.fixedDeltaTime);
    }
}
