using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerSwitch : MonoBehaviour
{
    public GameObject player1; // Assign the GameObject for Player1 in the Inspector
    public GameObject player2; // Assign the GameObject for Player2 in the Inspector

    private PlayerController player1Controller; // Store the PlayerController component for Player1
    private PlayerController player2Controller; // Store the PlayerController component for Player2

    void Start()
    {
        player1Controller = player1.GetComponent<PlayerController>();
        player2Controller = player2.GetComponent<PlayerController>();

        // Disable Player2's controller at the start of the game
        player2Controller.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Switch the PlayerController component between Player1 and Player2
            bool player1ControllerActive = player1Controller.enabled;
            player1Controller.enabled = !player1ControllerActive;
            player2Controller.enabled = player1ControllerActive;
        }
    }
}
