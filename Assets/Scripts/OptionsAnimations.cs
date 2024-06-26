using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Controlls the animations for the options menu
public class OptionsAnimations : MonoBehaviour
{
    public GameObject mainMenu;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Get the animator for the options menu
        animator = GetComponent<Animator>();
    }

    // This is called when the slide out animation is finished
    // Set the options menu to inactive
    // Update the animation state
    void SetOptionsInactive()
    {
        gameObject.SetActive(false);
        animator.SetInteger("InOptions", 0);
    }

    // This is called halfway through the slide out animation
    // So that the main menu re-appears smoothly
    void SetMainMenuActive()
    {
        mainMenu.SetActive(true);
    }
}
