using UnityEngine;

namespace MyAssets.Patterns.ServiceLocator
{
    public class ConsoleAudioService : IAudioService
    {
        public void PlayLevelSound()
        {
            Debug.Log("PlayLevelSound from ConsoleAudioService");
        }

        public void PlayWinSound()
        {
            Debug.Log("PlayWinSound from ConsoleAudioService");
        }

        public void StopLevelSound()
        {
            Debug.Log("Stop from ConsoleAudioService");
        }
    }
}