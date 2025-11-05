using UnityEngine;

/// <summary>
/// Class for debug practice via IDE
/// </summary>
public class DebugTest : MonoBehaviour {

    /// <summary>
    /// Player's health
    /// </summary>
    public int Health = 100;

    /// <summary>
    /// Player's damage
    /// </summary>
    public int Damage = 30;

    /// <summary>
    /// Init
    /// </summary>
    void Start() {
        var currentHealth = CalculateHealth();
        Debug.Log("Здоровье после удара: " + currentHealth);
        CheckStatus(currentHealth);
    }

    /// <summary>
    /// Calculates the current health of the player
    /// </summary>
    int CalculateHealth() {
        var current = Health;
        current -= Damage;
        current -= Damage / 2;
        return current;
    }

    /// <summary>
    /// Checks the player's status based on health points
    /// </summary>
    /// <param name="hp">Current health points of the player</param>
    void CheckStatus(int hp) {
        if (hp < 0) {
            Debug.LogError("Игрок умер!");
        } else if (hp == 0) {
            Debug.LogWarning("Игрок без сознания!");
        } else {
            Debug.Log($"Игрок жив: {hp}");
        }
    }
}
