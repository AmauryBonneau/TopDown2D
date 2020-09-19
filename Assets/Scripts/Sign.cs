using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;

public class Sign : MonoBehaviour
{
    // Declaring Player's animator because it will be useful for checking player's dir while in front of the sign
    [SerializeField]
    private Animator animator;
    private float playerDirection;

    [SerializeField]
    private GameObject dialogBox;
    [SerializeField]
    private Text dialogText;
    [SerializeField]
    private string dialog;
    
    [SerializeField]
    private bool signIsInteractible;

    private InputMaster playerActionControls;

    private void Awake()
    {
        playerActionControls = new InputMaster();
    }

    //If sign's game object is enabled... We enable the controls.
    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    //If sign's game object is disabled... We disable the controls.
    private void OnDisable()
    {
        playerActionControls.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Getting vertical part of player's dir.
        playerDirection = animator.GetFloat("Vertical");
        if ( (playerActionControls.GeneralGameplay.Attack.triggered) && signIsInteractible == true) //Was the action performed + the player in sign's range?
        {
            

            if (dialogBox.activeInHierarchy) //Closing dialog if it was already open.
            {
                UnityEngine.Debug.Log("BLA");
                dialogBox.SetActive(false);
            }

            else if (playerDirection == 1) //Player looking up and dialog not open, so we open it.
            {
                UnityEngine.Debug.Log("BLABLA");
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }

        if (playerDirection != 1) //Player is not looking up (or up-left, up-down), so we close the dialog.
        {
            dialogBox.SetActive(false);
        }

    }


    //Checking if player's collider enters the triggered sign's one if yes, sign may be interactible.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UnityEngine.Debug.Log("IN RANGE");
            signIsInteractible = true;
        }
    }

    //Checking if player's collider exits the triggered sign's one, if yes, sign is not interactible anymore.
    private void OnTriggerExit2D(Collider2D other)
    {
    if(other.CompareTag("Player"))
        {
            UnityEngine.Debug.Log("OUT OF RANGE");
            signIsInteractible = false;
            dialogBox.SetActive(false);
        }
    }

}
