using UnityEngine;

/// <summary>
/// Demo for lection 1
/// </summary>
public class L1 : MonoBehaviour {

    /// <summary>
    /// Rotation speed
    /// </summary>
    const float ROTATION_SPEED = 20f;

    /// <summary>
    /// Target object
    /// </summary>
    [SerializeField]
    GameObject _target = null;

    /// <summary>
    /// Cached transform
    /// </summary>
    Transform _transform = null;

    /// <summary>
    /// Cache target transform
    /// </summary>
    void Start() {
        if (_target != null) {
            _transform = _target.transform;
        }
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update() {
        if (_transform != null) {
            _transform.RotateAround(_transform.position, Vector3.up, ROTATION_SPEED * Time.deltaTime);
        }
    }
}
