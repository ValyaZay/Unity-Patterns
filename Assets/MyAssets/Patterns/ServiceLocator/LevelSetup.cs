using System.Collections;
using System.Collections.Generic;
using MyAssets.Patterns.ServiceLocator;
using UnityEditor.Experimental.RestService;
using UnityEngine;

public class LevelSetup : MonoBehaviour
{
    private IAudioService audioService;
    
    // Start is called before the first frame update
    void Start()
    {
        var gameStartup = new GameStartup();
        audioService = gameStartup.AudioLocator.AudioService;
    }

    public void PlayLevelAudio()
    {
        audioService.PlayLevelSound();
    }

    public void PlayWinAudio()
    {
        audioService.PlayWinSound();
    }

    public void StopLevelAudio()
    {
        audioService.StopLevelSound();
    }
}
