using UnityEngine;
using UnityEngine.UI;

namespace MyAssets
{
    public class Default : State
    {
        public Default(PlayerSystemViaPattern playerSystemViaPattern) : base(playerSystemViaPattern)
         {
         }
        
        public override void ShowPossibleActions()
        {
            MakeAllButtonsWhite();
        }

        public override void PresentCurrentState()
        {
            var currentState = PlayerState.Default; // this enum is necessary here because ShowCurrentState() method receives enum only
            PlayerSystemViaPattern.presenter.ShowCurrentState(currentState);
        }

        private void MakeAllButtonsWhite()
        {
            var buttons = PlayerSystemViaPattern.buttons;
            
            foreach (var button in buttons)
            {
                button.GetComponent<Image>().color = Color.white;
            }
        }
    }
}