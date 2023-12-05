using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

namespace Muratich {
    public class ProgrammingPanelOpen : MonoBehaviour
    {
        public GameObject panel;
        public Button firstButton;

        public void OpenProgrammingPanel(InputAction.CallbackContext value) {
            if (Controller.Control) {
                Controller.Control = false;
                panel.SetActive(true);
                firstButton.Select();
            }
        }

        public void CloseProgrammingPanel() {
            Controller.Control = true;
            panel.SetActive(false);
        }
    }
}