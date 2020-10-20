namespace MyAssets
{
    public abstract class State
    {
        protected PlayerSystemViaPattern PlayerSystemViaPattern;

        public State(PlayerSystemViaPattern playerSystemViaPattern)
        {
            PlayerSystemViaPattern = playerSystemViaPattern;
        }
        
        public virtual void ShowPossibleActions()
        {
        }

        public virtual void PresentCurrentState()
        {
        }
    }
}