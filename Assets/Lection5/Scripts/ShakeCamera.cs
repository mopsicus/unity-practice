using Unity.Cinemachine;
using UnityEngine;

public class ShakeCamera : MonoBehaviour {

    /// <summary>
    /// Amount by which the camera distance is increased during the shake effect
    /// </summary>
    [SerializeField]
    float _recoilAmount = 0.3f;

    /// <summary>
    /// Speed at which the camera moves during the shake effect
    /// </summary>
    [SerializeField]
    float _recoilSpeed = 10f;

    /// <summary>
    /// Speed at which the camera returns to its original position after shaking
    /// </summary>
    [SerializeField]
    float _returnSpeed = 5f;

    /// <summary>
    /// Cinemachine camera component
    /// </summary>
    CinemachineCamera _camera;

    /// <summary>
    /// Follow component of the Cinemachine camera
    /// </summary>
    CinemachineThirdPersonFollow _follow;

    /// <summary>
    /// Original distance of the camera from the target
    /// </summary>
    float _distance = 0f;

    /// <summary>
    /// Current offset for the camera distance during shake
    /// </summary>
    float _currentOffset = 0f;

    /// <summary>
    /// Current target offset for the camera distance during shake
    /// </summary>
    float _targetOffset = 0f;

    /// <summary>
    /// Initialize
    /// </summary>
    void Awake() {
        _camera = GetComponent<CinemachineCamera>();
        if (_camera != null) {
            _follow = _camera.GetComponent<CinemachineThirdPersonFollow>();
            if (_follow != null) {
                _distance = _follow.CameraDistance;
            }
        }
    }

    /// <summary>
    /// Updates the camera distance to create a shake effect
    /// </summary>
    void Update() {
        if (_follow == null) {
            return;
        }
        _targetOffset = Mathf.Lerp(_targetOffset, 0f, _returnSpeed * Time.deltaTime);
        _currentOffset = Mathf.Lerp(_currentOffset, _targetOffset, _recoilSpeed * Time.deltaTime);
        _follow.CameraDistance = _distance + _currentOffset;
    }

    /// <summary>
    /// Triggers the camera shake effect by increasing the target offset
    /// </summary>
    public void Shake() {
        _targetOffset += _recoilAmount;
    }
}
