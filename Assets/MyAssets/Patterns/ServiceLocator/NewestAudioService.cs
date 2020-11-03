using UnityEngine;

namespace MyAssets.Patterns.ServiceLocator
{
    public class NewestAudioService : IAudioService
    {
        public void PlayLevelSound()
        {
            Debug.Log("PlayLevelSound from NewestAudioService");
        }

        public void PlayWinSound()
        {
            Debug.Log("PlayWinSound from NewestAudioService");
        }

        public void StopLevelSound()
        {
            Debug.Log("StopLevelSound from NewestAudioService");
        }
    }
}