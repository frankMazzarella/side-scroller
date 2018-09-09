using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody player;
    private int jumpForce = 3500;
    private int doubleJumpForce = 4500;
    private float moveSpeed = 3.5f;
    private bool allowJump = true;
    private bool allowDoubleJump = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            handleJump();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveRight();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveLeft();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Ground")
        {
            allowJump = true;
            allowDoubleJump = false;
        }
    }

    private void handleJump()
    {
        if (allowDoubleJump)
        {
            Debug.Log("double jump");
            allowJump = false;
            allowDoubleJump = false;
            player.AddForce(0, doubleJumpForce, 0);
        }

        if (allowJump)
        {
            Debug.Log("single jump");
            allowJump = false;
            allowDoubleJump = true;
            player.AddForce(0, jumpForce, 0);
        }
    }

    private void moveRight()
    {
        Vector3 position = player.transform.position;
        position.x += moveSpeed * Time.deltaTime;
        player.transform.position = position;
    }

    private void moveLeft()
    {
        Vector3 position = player.transform.position;
        position.x -= moveSpeed * Time.deltaTime;
        player.transform.position = position;
    }
}
