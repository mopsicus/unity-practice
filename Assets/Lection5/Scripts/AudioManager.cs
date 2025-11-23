using UnityEngine;

public class AudioManager : MonoBehaviour {

    /// <summary>
    /// Audio clip for shooting sound
    /// </summary>
    [SerializeField]
    AudioClip _shootClip = null;

    /// <summary>
    /// Audio clip for wall collision sound
    /// </summary>
    [SerializeField]
    AudioClip _wallClip = null;

    /// <summary>
    /// Audio source for shooting sound
    /// </summary>
    AudioSource _shoot = null;

    /// <summary>
    /// Audio source for wall collision sound
    /// </summary>
    AudioSource _wall = null;

    /// <summary>
    /// Initializes the audio sources
    /// </summary>
    void Awake() {
        _shoot = gameObject.AddComponent<AudioSource>();
        _wall = gameObject.AddComponent<AudioSource>();
    }

    /// <summary>
    /// Plays the shooting sound
    /// </summary>
    public void PlayShoot() {
        _shoot.PlayOneShot(_shootClip);
    }

    /// <summary>
    /// Plays the wall collision sound
    /// </summary>
    public void PlayWall() {
        _wall.PlayOneShot(_wallClip);
    }
}
