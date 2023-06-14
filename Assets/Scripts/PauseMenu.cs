using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public static bool GraveInteraction = false;
    public GameObject GraveInteractionUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Dialogue() {
        if (Input.GetButtonDown("Fire2")) {
            if (GraveInteraction) {
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
