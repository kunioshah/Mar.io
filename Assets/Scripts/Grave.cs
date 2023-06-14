using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grave : MonoBehaviour
{
    public bool playerIsClose = false;
    PauseMenu pauseMenu;
    public static bool GraveInteraction = false;
    public GameObject GraveInteractionUI;

    void Update()
    {
       // Dialogue();
    }
    private void OnTriggerEnter2D() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("asdg");
        }
        Debug.Log("heyo");
        playerIsClose = true;
        Dialogue();
    }

    private void OnTriggerExit2D() {
        playerIsClose = false;
    }

    public void Dialogue() {
        if (Input.GetButtonDown("Fire2")) {
            Debug.Log("hasdeyaso");
            if (GraveInteraction) {
                 Debug.Log("heyaso");
                Resume();
            } else {
                Pause();
            }
        }
    }

    void Resume() {
        GraveInteractionUI.SetActive(false);
        Time.timeScale = 1f;
        GraveInteraction = false;
    }
    void Pause() {
        GraveInteractionUI.SetActive(true);
        Time.timeScale = 0f;
        GraveInteraction = true;
    }
}
