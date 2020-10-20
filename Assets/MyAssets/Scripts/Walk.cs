using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace MyAssets
{
    public class Walk : State
    {
        public Walk(PlayerSystemViaPattern playerSystemViaPattern) : base(playerSystemViaPattern)
        {
        }

        public override void ShowPossibleActions()
        {
            MakeGreenIdle();
            MakeGreenJump();
        }

        public override void PresentCurrentState()
        {
            var currentState = PlayerState.Walk; // this enum is necessary here because ShowCurrentState() method receives enum only
            PlayerSystemViaPattern.presenter.ShowCurrentState(currentState);
        }
        
        private void MakeGreenIdle()
        {
            var gameObject = PlayerSystemViaPattern.buttons.FirstOrDefault(b => b.name == "Idle");
            gameObject.GetComponent<Image>().color = Color.green;
        }
        
        private void MakeGreenJump()
        {
            var gameObject = PlayerSystemViaPattern.buttons.FirstOrDefault(b => b.name == "Jump");
            gameObject.GetComponent<Image>().color = Color.green;
        }
    }
}