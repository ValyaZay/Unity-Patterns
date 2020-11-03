namespace MyAssets.Patterns.ServiceLocator
{
    public class AudioLocator
    {
        public IAudioService AudioService { get; set; }

        public AudioLocator(IAudioService audioService)
        {
            AudioService = audioService;
        }
    }
}