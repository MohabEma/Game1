using UnityEngine;
using UnityEngine.SceneManagement;
using XInputDotNetPure;

public class KazControl : MonoBehaviour
{
    [Header("Speed Settings")]
    public float MovementSpeed = 3;
    public float JumpForce = 5;
    public float RunSpeed = 3;
    [Header("EXT Settings")]
    bool facingRight = true;
    private Rigidbody2D _rigidbody;
    public Collider2D boxCollider2d;

    [SerializeField]
    private LayerMask ground;
    PlayerIndex playerIndex;
    GamePadState state;
    GamePadState prevState;

    //EXT Features
    [Header("Graphical Settings")]
    public Animator animator;
    public ParticleSystem dustEffect;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        animator.SetFloat("Speed", Mathf.Abs(movement));

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }

        if (movement < 0 && facingRight)
        {
            flip();
        }
        else if (movement > 0 && !facingRight)
        {
            flip();
        }

        if (movement < 0)
        {
            GamePad.SetVibration(playerIndex, 0.015f, 0.015f);
        }
        else if (movement > 0)
        {
            GamePad.SetVibration(playerIndex, 0.015f, 0.015f);
        }
        else
        {
            GamePad.SetVibration(playerIndex, 0f, 0f);
        }

        if (Mathf.Abs(_rigidbody.velocity.y) > 0.001f)
        {
            GamePad.SetVibration(playerIndex, 0f, 0f);
        }

        if (Input.GetButton("Sprint"))
        {
            MovementSpeed = RunSpeed;
            animator.SetBool("Run", true);
        }
        else
        {
            MovementSpeed = 3;
            animator.SetBool("Run", false);
        }
    }
    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
        dust();
    }

    public void dust()
    {
        dustEffect.Play();
    }

    public bool IsGrounded()
    {
        float ext = .5f;
        RaycastHit2D raycasthit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, ext, ground);
        return raycasthit.collider != null;
    }
}
