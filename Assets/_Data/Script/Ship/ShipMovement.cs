using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    [SerializeField] protected float speed = 0.1f;
    [SerializeField] protected Vector3 worldPosition;

    void FixedUpdate()
    {
        this.GetMousePos();
        this.LookAtTarget();
        this.Moving();
    }

    protected virtual void GetMousePos()
    {
        this.worldPosition = InputManager.Instance.MouseWorldPosition;
        this.worldPosition.z = 0;
    }

    protected virtual void LookAtTarget()
    {
        Vector3 direction = this.worldPosition - transform.parent.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    protected virtual void Moving()
    {
        Vector3 newPosition = Vector3.Lerp(transform.parent.position, this.worldPosition, this.speed);
        transform.parent.position = newPosition;
    }
}
