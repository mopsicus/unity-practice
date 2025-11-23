using NUnit.Framework;

public class EditModeTests {

    /// <summary>
    /// Demo Player class
    /// </summary>
    class Player {

        /// <summary>
        /// Player's health points
        /// </summary>
        public int Health { get; private set; }

        /// <summary>
        /// Player's name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Constructor for the Player class
        /// </summary>
        /// <param name="health">Health value</param>
        public Player(string name, int health) {
            Name = name;
            Health = health;
        }

        /// <summary>
        /// Reduces the player's health by the specified damage amount
        /// </summary>
        /// <param name="damage">Damage amount</param>
        public void TakeDamage(int damage) {
            Health -= damage;
        }
    }

    /// <summary>
    /// Tests that the player's health is equal to the initial value
    /// </summary>
    [Test]
    public void Player_Health_Equals_Initial_Value() {
        var player = new Player("TestPlayer", 100);
        Assert.AreEqual(100, player.Health);
    }

    /// <summary>
    /// Tests that the player's name is equal to the initial value
    /// </summary>
    [Test]
    public void Player_Name_Equals_Initial_Value() {
        var player = new Player("TestPlayer", 100);
        Assert.AreEqual("TestPlayer", player.Name);
    }

    /// <summary>
    /// Tests that the player's health is reduced correctly when taking damage
    /// </summary>
    [Test, Category("Damage")]
    public void Player_TakeDamage_ReducesHealth() {
        var player = new Player("TestPlayer", 100);
        player.TakeDamage(10);
        Assert.AreEqual(90, player.Health);
    }

    /// <summary>
    /// Tests that the player's health is reduced correctly when taking damage
    /// </summary>
    [Test, Category("Damage")]
    public void Player_TakeDamage_CorrectlyReducesHealth() {
        var player = new Player("TestPlayer", 100);
        player.TakeDamage(10);
        Assert.AreEqual(90, player.Health);
    }
}
