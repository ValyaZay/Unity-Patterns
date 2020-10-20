using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace MyAssets
{
    public class Jump : State
    {
        public Jump(PlayerSystemViaPattern playerSystemViaPattern) : base(playerSystemViaPattern)
        {
        }

        public override void ShowPossibleActions()
        {
            MakeGreenIdle();
            MakeGreenWalk();
            MakeGreenFly();
        }

        public override void PresentCurrentState()
        {
            var currentState = PlayerState.Jump; // this enum is necessary here because ShowCurrentState() method receives enum only
            PlayerSystemViaPattern.presenter.ShowCurrentState(currentState);
        }

        private void MakeGreenIdle()
        {
            var gameObject = PlayerSystemViaPattern.buttons.FirstOrDefault(b => b.name == "Idle");
            gameObject.GetComponent<Image>().color = Color.green;
        }
        
        private void MakeGreenWalk()
        {
            var gameObject = PlayerSystemViaPattern.buttons.FirstOrDefault(b => b.name == "Walk");
            gameObject.GetComponent<Image>().color = Color.green;
        }
        
        private void MakeGreenFly()
        {
            var gameObject = PlayerSystemViaPattern.buttons.FirstOrDefault(b => b.name == "Fly");
            gameObject.GetComponent<Image>().color = Color.green;
        }
    }
}