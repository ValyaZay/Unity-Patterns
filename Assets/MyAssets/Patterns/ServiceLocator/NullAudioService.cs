using UnityEngine;

namespace MyAssets.Patterns.ServiceLocator
{
    public class NullAudioService : IAudioService
    {
        public void PlayLevelSound()
        {
            Debug.Log("I'm null object");
        }

        public void PlayWinSound()
        {
            Debug.Log("I'm null object");
        }

        public void StopLevelSound()
        {
            Debug.Log("I'm null object");
        }
    }
}