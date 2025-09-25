using UnityEngine;

/// <summary>
/// Base class for all enemies
/// </summary>
public class EnemyBase : MonoBehaviour {

    /// <summary>
    /// Target name
    /// </summary>
    protected string Nick = "Unknown";

    /// <summary>
    /// Target health
    /// </summary>
    protected float Health = 0f;

    /// <summary>
    /// Target speed
    /// </summary>
    protected float Speed = 0f;

    /// <summary>
    /// Target damage
    /// </summary>
    protected float Damage = 0f;

    /// <summary>
    /// Move to
    /// </summary>
    public virtual void Move() {
        transform.position += Vector3.forward * Speed;
    }
}
