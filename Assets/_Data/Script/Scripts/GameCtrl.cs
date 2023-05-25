using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : DucHienMonoBehaviour
{
    private static GameCtrl instance;
    public static GameCtrl Instance { get { return instance; } }

    [SerializeField] private Camera mainCamera;
    public Camera MainCamera { get { return mainCamera; } }

    protected override void Awake()
    {
        base.Awake();
        if(GameCtrl.instance != null) Debug.LogError("GameCtrl: Instance is not null");
        GameCtrl.instance = this;
    }
    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadMainCamera();
    }

    protected virtual void LoadMainCamera()
    {
        if(this.mainCamera != null) return;
        this.mainCamera = GameCtrl.FindObjectOfType<Camera>();
        Debug.Log("GameCtrl: Main camera is " + this.mainCamera.name);
    }
}
