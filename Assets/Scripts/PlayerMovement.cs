using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 15f;
    public float jumpForce = 4f;
    public Rigidbody rb;

    private Vector3 jump;
    private bool isGrounded;
    public float bhopSpeed = 10f;

    private void Start()
    {
        jump = new Vector3(0, jumpForce, 0);
    }
    private void OnCollisionEnter()
    {
        isGrounded = true;
        speed = 15f;
    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //transform.position += move * Time.deltaTime;
        if (Input.GetButtonDown("Jump") && isGrounded)
        {

            speed += bhopSpeed;
            isGrounded = false;
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);


        }

        // if (Input.GetKeyDown(KeyCode.LeftAlt))
        // {
        //    FindObjectOfType<GameManager>().EndGame();
        // }
    }

    private void stopMovement()
    {
        rb.isKinematic = true;
    }

    private void movement(float x, float z)
    {
        Vector3 move = transform.right * x * speed + transform.forward * z * speed;
        rb.AddForce(move);
        stopMovement();
    }

}
