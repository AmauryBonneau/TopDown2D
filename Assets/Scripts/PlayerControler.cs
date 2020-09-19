using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 5f;

    [SerializeField]
    private Rigidbody2D playerRB;
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private InputMaster playerActionControls;

    private Vector2 playerMovement;

    //Awake is called before start, convinient for set up
    private void Awake()
    {
        playerActionControls = new InputMaster();
    }


    //If Player's game object is enabled... We enable the controls.
    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    //If Player's game object is disabled... We disable the controls.
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
        if (playerActionControls.GeneralGameplay.Attack.ReadValue<float>() != 0)
            {
            UnityEngine.Debug.Log(playerActionControls.GeneralGameplay.Attack.ReadValue<float>());
            }

        //Movement values
        //Below, I quantize each axis to account for joypad support. This way, you are still limited to 8 dir movement even with a 360° joystick.
        //Also, I now use the new unity input system.

        if (
            (playerActionControls.GeneralGameplay.WalkHorizontal.ReadValue<float>()) < -0.3f
            )
        { playerMovement.x = -1; }
        else if (
            (playerActionControls.GeneralGameplay.WalkHorizontal.ReadValue<float>()) > 0.3f
                )
        { playerMovement.x = 1; }
        else playerMovement.x = 0;

        if (
           (playerActionControls.GeneralGameplay.WalkVertical.ReadValue<float>()) < -0.3f
           )
        { playerMovement.y = -1; }
        else if (
            (playerActionControls.GeneralGameplay.WalkVertical.ReadValue<float>()) > 0.3f
                )
        { playerMovement.y = 1; }
        else playerMovement.y = 0;


        //Legacy for input registering before the quantization + new input system:
        //playerMovement.x = Input.GetAxisRaw("Horizontal");
        //playerMovement.y = Input.GetAxisRaw("Vertical");


        //Communication with animation controller, setting the animator's parameters' values with our registered inputs
        if (playerMovement != Vector2.zero) //We charge our values in the controller's parameters only if actually moving, it permits to keep their last known moving value in the animator so that it allows our directional idle animations (and in other scripts, checking player dir from his animator)
        {
            animator.SetFloat("Horizontal", playerMovement.x);
            animator.SetFloat("Vertical", playerMovement.y);
        }
        animator.SetFloat("Speed", playerMovement.sqrMagnitude); //We use sqrMagnitude to take the square root  of the magnitude of our movement vector for performance sake, the squaring itself is to keep diagonal moving at the same speed as horizontal and vertical

    }

    void FixedUpdate() //better than Update for parts involving physics because FixedUpdate accounts for framerate inconsistencies 
    {
        //Movement handling
        
        //Walking
        playerRB.MovePosition(playerRB.position + playerMovement.normalized * playerSpeed * Time.fixedDeltaTime); //adds the playerMovement vector to our rb position, Time.fixedDeltaTime acounts for a constant speed (it is the amount of time that has elapsed since last time FixedUpdate was called)

        //Jumping


        //Sword Slash


    }
}
