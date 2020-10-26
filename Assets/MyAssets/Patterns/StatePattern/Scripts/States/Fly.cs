using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace MyAssets
{
    public class Fly : State
    {
        public Fly(PlayerSystemViaPattern playerSystemViaPattern) : base(playerSystemViaPattern)
        {
        }

        public override void ShowPossibleActions()
        {
            MakeRedIdle();
            MakeRedJump();
            MakeRedWalk();
        }

        public override void PresentCurrentState()
        {
            var currentState = PlayerState.Fly; // this enum is necessary here because ShowCurrentState() method receives enum only
            PlayerSystemViaPattern.presenter.ShowCurrentState(currentState);
        }
        
        private void MakeRedWalk()
        {
            var gameObject = PlayerSystemViaPattern.buttons.FirstOrDefault(b => b.name == "Walk");
            gameObject.GetComponent<Image>().color = Color.red;
        }

        private void MakeRedJump()
        {
            var gameObject = PlayerSystemViaPattern.buttons.FirstOrDefault(b => b.name == "Jump");
            gameObject.GetComponent<Image>().color = Color.red;
        }
    
        private void MakeRedIdle()
        {
            var gameObject = PlayerSystemViaPattern.buttons.FirstOrDefault(b => b.name == "Idle");
            gameObject.GetComponent<Image>().color = Color.red;
        }
    }
}