using UnityEngine;
using UnityEngine.SceneManagement;

public class Character2DController : MonoBehaviour
{
    [Header("Speed Settings")]
    public float MovementSpeed = 1;
    public float JumpForce = 5;
    public float RunSpeed = 3;
    [Header("EXT Settings")]
    bool facingRight = true;
    private Rigidbody2D _rigidbody;
    public Collider2D boxCollider2d;

    //EXT Features
    [Header("Graphical Settings")]
    public Animator animator;
    public AudioSource jumpAudio;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        Cursor.visible = false;
    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        animator.SetFloat("Speed", Mathf.Abs(movement));

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            jumpAudio.Play();
            
        }

        if (movement < 0 && facingRight)
        {
            flip();
        }
        else if (movement > 0 && !facingRight)
        {
            flip();
        }

        if (Input.GetButton("Sprint"))
        {
            MovementSpeed = RunSpeed;
        }
        else
        {
            MovementSpeed = 1;
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            //Controls Menu Cut
        }
        else
        {
            //Menu Cut, New Training Has Made This Not Needed
        }

    }
    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
    
    

