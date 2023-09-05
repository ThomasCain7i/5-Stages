using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Animator anim;
    public GameObject monster;

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
    public bool isJumping, isGrounded, CanDJump, isDJumping, isCrouching;
    public bool isInteracting;

    [Header("Spawn Point")]
    public Vector2 spawnPoint;

    [Header("References")]
    [SerializeField]
    private AngerMeter angerMeter;
    [SerializeField]
    private GameObject PauseMenu;
    PauseMenu refToPauseMenuScript;
    [SerializeField]
    GameManager gameManager;



    void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (refToPauseMenuScript != null)
        {
            refToPauseMenuScript = FindObjectOfType<PauseMenu>();
        }


    }
    private void OnDestroy()
    {
        // Unsubscribe from the sceneLoaded event to prevent memory leaks
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

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
        //gameManager = FindObjectOfType<GameManager>();
        //gameManager.LoadSettings();
        anim = GetComponentInChildren<Animator>();
        RB = GetComponent<Rigidbody2D>();

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
        if (this.GetComponentInChildren<Animator>() != null)
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
        if (isCrouching)
        {
            anim.SetTrigger("isCrouching");
        }
        if (!isCrouching)
        {
            anim.SetBool("isCrouching", false);
        }
        if (YInput <= -0.01f)
        {
            isCrouching = true;
        }
        if (YInput >= 0.0f)
        {
            isCrouching = false;
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
            isInteracting = true;
        }
        else isInteracting = false;
        if (isInteracting)
        {
            anim.SetTrigger("InteractingKey");
        }
        if (!isInteracting)
        {
            anim.ResetTrigger("InteractingKey");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Death"))
        {
            Destroy(monster);
            anim.SetTrigger("Death");
            Speed = 0;
        }
    }
}