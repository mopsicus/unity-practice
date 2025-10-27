#pragma warning disable IDE0060 

using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.InputSystem.InputAction;

/// <summary>
/// Panel with health bar
/// </summary>
public class PlayerPanel : MonoBehaviour {

    /// <summary>
    /// Reference to the health bar image
    /// </summary>
    [SerializeField]
    Image _healthBar = null;

    /// <summary>
    /// Callback when player press H
    /// </summary>
    public void OnHeal(CallbackContext input) {
        _healthBar.fillAmount += 0.1f;
    }

    /// <summary>
    /// Callback when player press D
    /// </summary>
    public void OnDamage(CallbackContext input) {
        _healthBar.fillAmount -= 0.1f;
    }
}
