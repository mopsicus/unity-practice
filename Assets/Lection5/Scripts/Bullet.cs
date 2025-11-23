using UnityEngine;

public class Bullet : MonoBehaviour {

    /// <summary>
    /// Wall object name
    /// </summary>
    const string WALL_OBJECT = "Wall";

    /// <summary>
    /// Raise when the player collides with another object
    /// </summary>
    void OnCollisionEnter(Collision collision) {
        var item = collision.gameObject.name;
        if (item.Contains(WALL_OBJECT)) {
            EventBus.Publish<BulletEvent>(BulletEvent.WallDetected);
        }
    }
}
