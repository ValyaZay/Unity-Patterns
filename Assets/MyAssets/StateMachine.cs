using UnityEngine;

namespace MyAssets
{
    public abstract class StateMachine : MonoBehaviour
    {
        protected State State;

        public void SetState(State state)
        {
            State = state;
            State.ShowPossibleActions();
            State.PresentCurrentState();
        }
    }
}