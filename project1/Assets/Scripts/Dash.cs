using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
   
    private Rigidbody2D rigidbody;
    private float moveInput;
    private SpriteRenderer sprRend;
    public Animator animator;
    public GameObject walkParticle;
    public bool grounded;
    
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    public GameObject dashParticle;
    public TrailRenderer trailRenderer;
    private GameObject cam;
    private Animator camAnim;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
        camAnim = cam.GetComponent<Animator>();

        rigidbody = GetComponent<Rigidbody2D>();

        dashTime = startDashTime;

        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(Color.cyan, 0.0f), new GradientColorKey(Color.white, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(0, 1.0f) }
        );
        trailRenderer.colorGradient = gradient;
    }

    void Update()
    {
        moveInput = Input.GetAxis("Horizontal");

      


      



        if (direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                if (moveInput < 0)
                {
                    Instantiate(dashParticle, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
                    animator.SetTrigger("dash");
                    camAnim.SetTrigger("zoomin");
                    direction = 1;
                }
                else if (moveInput > 0)
                {
                    Instantiate(dashParticle, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
                    animator.SetTrigger("dash");
                    camAnim.SetTrigger("zoomin");
                    direction = 2;
                }
            }
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rigidbody.velocity = Vector2.zero;
                //trailRenderer.widthCurve = new AnimationCurve(new Keyframe(0, 0.27f), new Keyframe(0.5f, 0.7f), new Keyframe(1, 0));
                Gradient gradient = new Gradient();
                gradient.SetKeys(
                    new GradientColorKey[] { new GradientColorKey(Color.cyan, 0.0f), new GradientColorKey(Color.white, 1.0f) },
                    new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(0, 1.0f) }
                );
                trailRenderer.colorGradient = gradient;
            }
            else
            {
                Gradient gradient2 = new Gradient();
                gradient2.SetKeys(
                    new GradientColorKey[] { new GradientColorKey(Color.red, 0.0f), new GradientColorKey(Color.yellow, 1.0f) },
                    new GradientAlphaKey[] { new GradientAlphaKey(1, 0.0f), new GradientAlphaKey(0, 1.0f) }
                );
                trailRenderer.colorGradient = gradient2;
                Instantiate(dashParticle, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y), Quaternion.identity);
                dashTime -= Time.deltaTime;

                if (direction == 1)
                {
                    rigidbody.velocity = Vector2.left * dashSpeed;
                }
                else if (direction == 2)
                {
                    rigidbody.velocity = Vector2.right * dashSpeed;
                }
            }
        }

    }
}