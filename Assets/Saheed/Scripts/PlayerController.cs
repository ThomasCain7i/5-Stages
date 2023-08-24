using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;

    [Header("Type Of Player")]
    [SerializeField]
    private bool heavyPlayer;
    [SerializeField]
    private bool lightPlayer;

    [Header("Movement")]
    [Range(100, 1000)]
    [SerializeField] float Speed;
    Rigidbody2D RB;
    float XInput, YInput;

    [Header("Jump")]
    [Range(1, 10)]
    public float JumpVelocity;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    [Header("Player Bools")]
    [SerializeField]
    private bool isAnimationPlaying = false;
    public bool isJumping, isGrounded, CanDJump, isDJumping;
    public bool isInteracting;

    [Header("Spawn Point")]
    public Vector2 spawnPoint;

    [Header("References")]
    [SerializeField]
    private AngerMeter angerMeter;
    [SerializeField]
    private GameObject PauseMenu;
    PauseMenu refToPauseMenuScript;
    GameManager gameManager;



    [Header("Polaroids")]
    public int denial;
    public int anger, bargaining, depression, acceptance, final;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            anim.SetBool("isGrounded", true);
            isGrounded = true;
            CanDJump = true;
            // anim.ResetTrigger("isDJumping");
        }
    }

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        gameManager.LoadSettings();
        RB = GetComponent<Rigidbody2D>();
        refToPauseMenuScript = PauseMenu.GetComponentInParent<PauseMenu>();
        if (lightPlayer)
        {
            fallMultiplier = .5f;
            Speed = 300;
        }

        if (heavyPlayer)
        {
            JumpVelocity = 2f;
            fallMultiplier = 5f;
            Speed = 100f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Animation();
        Movement();

        if (angerMeter != null)
        {
            Speed = angerMeter.angerSpeedPercentage;
        }

        if (isAnimationPlaying == true || refToPauseMenuScript.isPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }
    private void FixedUpdate()
    {
        XInput = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        RB.velocity = new Vector2(XInput, RB.velocity.y);
    }


    public void SetAnimationPlaying(bool isPlaying)
    {
        isAnimationPlaying = isPlaying;
    }
    void Animation()
    {
        //walking animation
        anim.SetFloat("Speed", Mathf.Abs(XInput));

    }

    void Movement()
    {
        //Input
        XInput = Input.GetAxisRaw("Horizontal");
        YInput = Input.GetAxisRaw("Vertical");
        Jump();
        InteractingKey();

        //Flipping Sprite

        if (XInput >= 0.01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (XInput <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }

    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded == true)
            {
                RB.velocity = Vector2.up * JumpVelocity;
                isJumping = true;
                isGrounded = false;
                anim.SetBool("isGrounded", false);

            }
            else if (!isGrounded && CanDJump == true)
            {
                RB.velocity = Vector2.up * JumpVelocity;
                CanDJump = false;
                // anim.SetTrigger("isDJumping");

            }
        }
        else isJumping = false;
        if (isJumping == true)
        {
            anim.SetBool("isJumping", true);

        }
        if (isJumping == false)
        {
            anim.SetBool("isJumping", false);
        }

        BetterJump();


    }
    void BetterJump()
    {
        //Adds Weight and feel to the character's Jump <<<
        if (RB.velocity.y < 0)
        {
            RB.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (RB.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            RB.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }
    void InteractingKey()
    {
        if (Input.GetKey(KeyCode.E))
        {
            anim.SetTrigger("InteractingKey");
            isInteracting = true;
        }
        else isInteracting = false;
        if (!isInteracting)
        {
            anim.ResetTrigger("InteractingKey");
        }
    }
}