using UnityEngine;

/// <summary>
/// Demo class for tests
/// </summary>
public class PlayerData {

    /// <summary>
    /// Player's name
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Player's health
    /// </summary>
    public int Health { get; private set; }

    /// <summary>
    /// Player's data constructor
    /// </summary>
    /// <param name="name">Player's name</param>
    /// <param name="health">Player's health</param>
    public PlayerData(string name = "Player", int health = 100) {
        Name = name;
        Health = health;
    }

    /// <summary>
    /// Inflicts damage to the player
    /// </summary>
    /// <param name="amount">Amount of damage to inflict</param>
    public void TakeDamage(int amount) {
        Health = Mathf.Max(0, Health - amount);
    }
}
