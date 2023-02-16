using UnityEngine;

public class simpleMove : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5.0f;
    //[SerializeField] private float jumpPower = 5.0f;

    private Rigidbody2D _playerRigidbody;
    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        if (_playerRigidbody == null)
        {
            Debug.LogError("Player is missing a Rigidbody2D component");
        }
    }
    private void Update()
    {
        MovePlayer();

        if (transform.position.y > 3)
            transform.position = new Vector3(transform.position.x,3,-1);
        if (transform.position.y < -2)
            transform.position = new Vector3(transform.position.x,-2,-1);

        if (transform.position.x > 2)
            transform.position = new Vector3(2, transform.position.y,-1);
        if (transform.position.x < -6)
            transform.position = new Vector3(-6, transform.position.y,-1);

        //  if (Input.GetButton("Jump") && IsGrounded())
        //    Jump();
    }
    private void MovePlayer()
    {
        var horizontalInput = Input.GetAxisRaw("Horizontal");
        _playerRigidbody.velocity = new Vector2(horizontalInput * playerSpeed, _playerRigidbody.velocity.y);
        var verticalInput = Input.GetAxisRaw("Vertical");
        _playerRigidbody.velocity = new Vector2(verticalInput * playerSpeed, _playerRigidbody.velocity.x);


    }
    //private void Jump() => _playerRigidbody.velocity = new Vector2(0, jumpPower);

    /*private bool IsGrounded()
    {
        var groundCheck = Physics2D.Raycast(transform.position, Vector2.down, 0.7f);
        return groundCheck.collider != null && groundCheck.collider.CompareTag("Ground");
    }
    */

}