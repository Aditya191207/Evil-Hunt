using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController charactor;
    public Animator animator;
    private Vector3 direction;
    public float gravity = 9.81f * 2f;
    public float jumpForce = 8f;
    
    public AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        charactor = GetComponent<CharacterController>();
    }

  
    private void OnEnable()
    {
        direction = Vector3.zero;
    }
    private void Update()
    {
           if(Input.GetButton("Jump"))
            {
                audioManager.PlaySFX(audioManager.jumpSound);
                animator.SetBool("jump", true);
                animator.SetBool("run", false);
                 animator.SetBool("strike", false);
            }else if(Input.GetButton("Attack"))
            {
                audioManager.PlaySFX(audioManager.attackSound);
                animator.SetBool("strike", true);
                animator.SetBool("run", false);
                animator.SetBool("jump", false);
            }else{
                animator.SetBool("strike", false);
                animator.SetBool("jump", false);
                animator.SetBool("run", true);

            }
        direction += Vector3.down * gravity * Time.deltaTime;

        if(charactor.isGrounded)
        {
            direction = Vector3.down;
            if(Input.GetButton("Jump"))
            {
                direction = Vector3.up * jumpForce;
            }
        }
        charactor.Move(direction * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Obstacle")){
            GameManager.Instance.GameOver();
        }
    }
}
