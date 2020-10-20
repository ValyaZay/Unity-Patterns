using MyAssets;
using UnityEngine;

public class PlayerSystemViaPattern : StateMachine
{
    public CurrentStatePresenter presenter;
    public GameObject[] buttons;

    private void Awake()
    {
        presenter = FindObjectOfType<CurrentStatePresenter>();
        buttons = GameObject.FindGameObjectsWithTag("Button");
    }

    private void Start()
    {
        SetState(new Default(this));
    }

    public void OnIdle()
    {
        SetState(new Idle(this));
    }

    public void OnReset()
    {
        SetState(new Default(this));
    }
    
    public void OnJump()
    {
        SetState(new Jump(this));
    }
    
    public void OnWalk()
    {
        SetState(new Walk(this));
    }
    
    public void OnFly()
    {
        SetState(new Fly(this));
    }
}
