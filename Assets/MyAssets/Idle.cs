using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace MyAssets
{
    public class Idle : State
    {
        public Idle(PlayerSystemViaPattern playerSystemViaPattern) : base(playerSystemViaPattern)
        {
        }

        public override void ShowPossibleActions()
        {
            MakeGreenWalk();
            MakeGreenJump();
        }

        public override void PresentCurrentState()
        {
            var currentState = PlayerState.Idle; // this enum is necessary here because ShowCurrentState() method receives enum only
            PlayerSystemViaPattern.presenter.ShowCurrentState(currentState);
        }

        private void MakeGreenWalk()
        {
            var walkObj = PlayerSystemViaPattern.buttons.FirstOrDefault(b => b.name == "Walk");
            if (walkObj != null)
            {
                walkObj.GetComponent<Image>().color = Color.green;
            }
        }
        
        private void MakeGreenJump()
        {
            var gameObject = PlayerSystemViaPattern.buttons.FirstOrDefault(b => b.name == "Jump");
            gameObject.GetComponent<Image>().color = Color.green;
        }
    }
}