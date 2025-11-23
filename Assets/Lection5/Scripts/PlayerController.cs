using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Controls the player character's movement and rotation
/// </summary>
public class PlayerController : MonoBehaviour {

    /// <summary>
    /// Movement speed of the player
    /// </summary>
    [SerializeField]
    float _moving = 5f;

    /// <summary>
    /// Rotation speed of the player
    /// </summary>
    [SerializeField]
    float _rotation = 100f;

    /// <summary>
    /// Jump force applied to the player
    /// </summary>
    [SerializeField]
    float _jumpForce = 5f;

    /// <summary>
    /// Audio manager for playing sound effects
    /// </summary>
    [SerializeField]
    AudioManager _audio = null;

    /// <summary>
    /// Reference to the Gun component
    /// </summary>
    [SerializeField]
    Gun _gun = null;

    /// <summary>
    /// Reference to the ShakeCamera component
    /// </summary>
    [SerializeField]
    ShakeCamera _shaker = null;

    /// <summary>
    /// Cached reference to the Rigidbody component
    /// </summary>
    Rigidbody _body = null;

    /// <summary>
    /// Stores the current input from the player
    /// </summary>
    Vector2 _input = Vector2.zero;

    /// <summary>
    /// Tracks whether the player is on the ground
    /// </summary>
    bool _isGrounded = true;

    /// <summary>
    /// Initialize
    /// </summary>
    void Awake() {
        _body = GetComponent<Rigidbody>();
        EventBus.Subscribe<BulletEvent>(OnBulletEvent);
    }

    /// <summary>
    /// Handles bullet-related events
    /// </summary>
    void OnBulletEvent(BulletEvent action) {
        if (action == BulletEvent.WallDetected) {
            _audio.PlayWall();
        }
    }

    /// <summary>
    /// Handles player movement input
    /// </summary>
    /// <param name="value">Current input value from the player</param>
    public void OnMove(InputValue value) {
        _input = value.Get<Vector2>();
    }

    /// <summary>
    /// Handles player firing input
    /// </summary>
    public void OnFire() {
        if (_gun.Shoot()) {
            _audio.PlayShoot();
            _shaker.Shake();
        }
    }

    /// <summary>
    /// Handles player reload input
    /// </summary>
    public void OnReload() {
        _gun.Reload();
    }

    /// <summary>
    /// Handles player jump
    /// </summary>
    public void OnJump() {
        if (_isGrounded) {
            _body.linearVelocity = new Vector3(_body.linearVelocity.x, _jumpForce, _body.linearVelocity.z);
            _isGrounded = false;
        }
    }

    /// <summary>
    /// Handles physics-based movement and rotation of the player
    /// </summary>
    void FixedUpdate() {
        var movement = _input.y * _moving * transform.forward;
        _body.linearVelocity = new Vector3(movement.x, _body.linearVelocity.y, movement.z);
        if (_input.x != 0) {
            var rotation = _input.x * _rotation * Time.fixedDeltaTime;
            var delta = Quaternion.Euler(0f, rotation, 0f);
            _body.MoveRotation(_body.rotation * delta);
        }
    }

    /// <summary>
    /// Detects when the player touches the ground
    /// </summary>
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            _isGrounded = true;
        }
    }
}
