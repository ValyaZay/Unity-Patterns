using System.Collections;
using System.Collections.Generic;
using MyAssets;
using UnityEngine;
using UnityEngine.UI;

public class CurrentStatePresenter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCurrentState(PlayerState state)
    {
        GetComponent<Text>().text = $"Current state is {state.ToString()}";
    }
}
