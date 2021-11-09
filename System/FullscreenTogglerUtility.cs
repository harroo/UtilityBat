
using UnityEngine;

public class FullscreenTogglerUtility : MonoBehaviour {

    private Resolution highestResolution, currentResolution;

    private void Start () {

        foreach (Resolution resolution in Screen.resolutions) {

            if (
                resolution.width > highestResolution.width ||
                resolution.height > highestResolution.height
            ) {
                highestResolution = resolution;
            }
        }
    }

    private void Update () {

        if (!Input.GetKeyDown(KeyCode.F11)) return;

        Screen.fullScreen = !Screen.fullScreen;

        if (Screen.fullScreen) {

            currentResolution = Screen.currentResolution;
            Screen.SetResolution(highestResolution.width, highestResolution.height, true);

        } else {

            Screen.SetResolution(currentResolution.width, currentResolution.height, false);
        }
    }
}
