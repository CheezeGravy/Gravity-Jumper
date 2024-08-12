using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void CloseMenu() {
        Destroy(this.gameObject);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
