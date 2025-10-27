using System.Collections;
using System.Timers;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Health Bar UI
/// </summary>
public class UI : MonoBehaviour {

    /// <summary>
    /// Yellow color health threshold
    /// </summary>
    const int YELLOW_HEALTH_THRESHOLD = 75;

    /// <summary>
    /// Red color health threshold
    /// </summary>
    const int RED_HEALTH_THRESHOLD = 30;

    /// <summary>
    /// Health bar image
    /// </summary>
    [SerializeField]
    Image _bar = null;

    /// <summary>
    /// Offset position for the health bar
    /// </summary>
    [SerializeField]
    Vector3 _offset = new Vector3(0f, 2f, 0f);

    /// <summary>
    /// Cached bar transform
    /// </summary>
    Transform _target = null;

    Timer _timer = null;

    /// <summary>
    /// Initialize the health bar
    /// </summary>
    void Start() {
        _target = _bar.transform;
        StartCoroutine(Test());
        _timer = new Timer(1000f);
        _timer.Elapsed += OnTimer;
        _timer.Start();
    }

    private void OnTimer(object sender, ElapsedEventArgs e) {
        Debug.Log(timer);
    }

    int timer = 60;

    IEnumerator Test() {
        Debug.Log("1");
        Debug.Log("2");
        while (timer > 0) {
            timer--;
            yield return new WaitForSeconds(1f);
            Debug.Log(timer);
        }
    }

    /// <summary>
    /// Update the health bar position and rotation
    /// </summary>
    void Update() {
        _target.SetPositionAndRotation(transform.position + _offset, Quaternion.LookRotation(transform.position - Camera.main.transform.position));
    }

    /// <summary>
    /// Set the health value
    /// </summary>
    /// <param name="health">The health value</param>
    public void SetHealth(int health) {
        _bar.fillAmount = health / 100f;
        _bar.color = health switch {
            <= RED_HEALTH_THRESHOLD => Color.red,
            <= YELLOW_HEALTH_THRESHOLD => Color.yellow,
            _ => Color.green,
        };
        Debug.Log($"[{nameof(UI).ToUpperInvariant()}] health percent: {_bar.fillAmount}");
    }
}
