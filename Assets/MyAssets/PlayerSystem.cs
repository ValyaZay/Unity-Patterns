using System;
using System.Collections;
using System.Collections.Generic;
using MyAssets;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSystem : MonoBehaviour
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
            MakeJumpGreen();
        }
        
        else if (state == PlayerState.Default)
        {
            MakeAllButtonsWhite();
        } 
    }

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

    private void MakeJumpGreen()
    {
        var walkObj = GameObject.Find("Jump");
        walkObj.GetComponent<Image>().color = Color.green;
    }
}
