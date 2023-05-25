using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance { get { return instance; } }

    [SerializeField] protected Vector3 mouseWorldPosition;
    public Vector3 MouseWorldPosition { get { return this.mouseWorldPosition; } }

    [SerializeField] protected float onFiring;
    public float OnFiring { get { return this.onFiring; } }

    private void Awake()
    {
        if(InputManager.instance != null)
        {
            Debug.LogError("There is more than one InputManager in the scene!");
        }
        InputManager.instance = this;
    }
    void Update()
    {
        GetMouseDown();
    }
    void FixedUpdate()
    {
        GetMousePos();
    }

    protected virtual void GetMousePos()
    {
        this.mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    protected virtual void GetMouseDown()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }
}
