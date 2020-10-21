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
        TurnOnStateMachine();
    }

    public void OnIdle()
    {
        SetState(new Idle(this));
        TurnOnStateMachine();
    }

    public void OnReset()
    {
        SetState(new Default(this));
        TurnOnStateMachine();
    }
    
    public void OnJump()
    {
        SetState(new Jump(this));
        TurnOnStateMachine();
    }
    
    public void OnWalk()
    {
        SetState(new Walk(this));
        TurnOnStateMachine();
    }
    
    public void OnFly()
    {
        SetState(new Fly(this));
        TurnOnStateMachine();
    }

    private void TurnOnStateMachine()
    {
        State.ShowPossibleActions();
        State.PresentCurrentState();
    }
    
}
