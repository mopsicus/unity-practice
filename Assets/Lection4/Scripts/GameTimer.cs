using System.Collections;
using TMPro;
using UnityEngine;

/// <summary>
/// Timer for the game
/// </summary>
public class GameTimer : MonoBehaviour {

    /// <summary>
    /// Cached WaitForSeconds
    /// </summary>
    static readonly WaitForSeconds _waiter = new WaitForSeconds(1f);

    /// <summary>
    /// Timer duration in seconds
    /// </summary>
    [SerializeField]
    int _timer = 60;

    /// <summary>
    /// Reference to the timer text
    /// </summary>
    [SerializeField]
    TextMeshProUGUI _timerText = null;

    /// <summary>
    /// Current timer value
    /// </summary>
    int _value = 0;

    /// <summary>
    /// Action on show screen
    /// </summary>
    void OnEnable() {
        StartCoroutine(Timer());
    }

    /// <summary>
    /// Action on disable screen
    /// </summary>
    void OnDisable() {
        StopCoroutine(Timer());
    }

    /// <summary>
    /// Timer coroutine
    /// </summary>
    IEnumerator Timer() {
        while (_value < _timer) {
            _timerText.SetText("Time: {0}", _timer - _value);
            _value++;
            yield return _waiter;
        }
    }

    /// <summary>
    /// Reset timer
    /// </summary>
    public void Reset() {
        _value = 0;
        StopCoroutine(Timer());
        StartCoroutine(Timer());
    }
}
