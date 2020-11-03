using System;
using UnityEngine;

namespace MyAssets.Patterns.ServiceLocator
{
    public class GameStartup
    {
        public AudioLocator AudioLocator;

        public GameStartup()
        {
            //var audioService = new ConsoleAudioService();
            var audioService = new NewestAudioService();
            AudioLocator = new AudioLocator(audioService); // dependency injection
        }
    }
}