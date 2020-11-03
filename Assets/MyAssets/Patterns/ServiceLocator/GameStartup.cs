using System;
using UnityEngine;

namespace MyAssets.Patterns.ServiceLocator
{
    public class GameStartup : MonoBehaviour
    {
        private void Awake()
        {
            //var audioService = new ConsoleAudioService();
            var audioService = new NewestAudioService();
            Locator.SetAudioService(audioService);
        }

    }
}