using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private float jumpForce = 10;

    private Rigidbody2D rigidbody;
    private IsGroundedChecker isGroundedChecker;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        isGroundedChecker = GetComponent<IsGroundedChecker>();
    }

    private void Start()
    {
        GameManager.Instance.InputManager.OnJump += HandleJump;
    }

    private void Update()
    {
        float moveDirection = GameManager.Instance.InputManager.Movement;
        transform.Translate(moveDirection * Time.deltaTime * moveSpeed, 0, 0);
    }

    private void HandleJump() 
    {
        if (!isGroundedChecker.IsGrounded()) return;
        rigidbody.linearVelocity = Vector2.up * jumpForce;
    }
}