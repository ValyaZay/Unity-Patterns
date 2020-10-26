using MyAssets;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSystemViaIf : MonoBehaviour
{
    private CurrentStatePresenter presenter;
    public PlayerState playerState = PlayerState.Default;

    private void Start()
    {
        presenter = FindObjectOfType<CurrentStatePresenter>();
        presenter.ShowCurrentState(playerState);
    }

    public void OnIdle()
    {
        playerState = PlayerState.Idle;
        TurnOnStateMachine(playerState);
    }

    public void OnReset()
    {
        playerState = PlayerState.Default;
        TurnOnStateMachine(playerState);
    }
    
    public void OnJump()
    {
        playerState = PlayerState.Jump;
        TurnOnStateMachine(playerState);
    }
    
    public void OnWalk()
    {
        playerState = PlayerState.Walk;
        TurnOnStateMachine(playerState);
    }
    
    public void OnFly()
    {
        playerState = PlayerState.Fly;
        TurnOnStateMachine(playerState);
    }

    private void TurnOnStateMachine(PlayerState playerState)
    {
        ShowPossibleActions(playerState);
        presenter.ShowCurrentState(playerState);
    }

    private void ShowPossibleActions(PlayerState state)
    {
        if (state == PlayerState.Idle)
        {
            MakeGreenWalk();
            MakeGreenJump();
        }
        
        else if (state == PlayerState.Default)
        {
            MakeAllButtonsWhite();
        } 
        
        else if (state == PlayerState.Jump)
        {
            MakeGreenIdle();
            MakeGreenWalk();
            MakeGreenFly();
        }
        
        else if (state == PlayerState.Walk)
        {
            MakeGreenIdle();
            MakeGreenJump();
        }
        
        else if (state == PlayerState.Fly)
        {
            MakeRedIdle();
            MakeRedJump();
            MakeRedWalk();
        }
    }

    #region Behaviors

    private void MakeAllButtonsWhite()
    {
        var buttons = GameObject.FindGameObjectsWithTag("Button");
        foreach (var button in buttons)
        {
            button.GetComponent<Image>().color = Color.white;
        }
    }
    
    private void MakeGreenWalk()
    {
        var walkObj = GameObject.Find("Walk");
        walkObj.GetComponent<Image>().color = Color.green;
    }

    private void MakeGreenJump()
    {
        var gameObject = GameObject.Find("Jump");
        gameObject.GetComponent<Image>().color = Color.green;
    }
    
    private void MakeGreenIdle()
    {
        var gameObject = GameObject.Find("Idle");
        gameObject.GetComponent<Image>().color = Color.green;
    }
    
    private void MakeGreenFly()
    {
        var gameObject = GameObject.Find("Fly");
        gameObject.GetComponent<Image>().color = Color.green;
    }
    
    private void MakeRedWalk()
    {
        var walkObj = GameObject.Find("Walk");
        walkObj.GetComponent<Image>().color = Color.red;
    }

    private void MakeRedJump()
    {
        var gameObject = GameObject.Find("Jump");
        gameObject.GetComponent<Image>().color = Color.red;
    }
    
    private void MakeRedIdle()
    {
        var gameObject = GameObject.Find("Idle");
        gameObject.GetComponent<Image>().color = Color.red;
    }

    #endregion
}
