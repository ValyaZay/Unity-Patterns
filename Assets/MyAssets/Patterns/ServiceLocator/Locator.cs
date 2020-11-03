namespace MyAssets.Patterns.ServiceLocator
{
    public class Locator
    {
        private static IAudioService _audioService;

        public static void SetAudioService(IAudioService audioService)
        {
            _audioService = audioService;
        }

        public static IAudioService GetAudioService()
        {
            return _audioService;
        }
    }
}