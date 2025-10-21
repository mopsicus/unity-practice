using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Show selected player index
/// </summary>
public class SceneDemo : MonoBehaviour {

    /// <summary>
    /// Name of the scene to load
    /// </summary>
    const string SCENE_NAME = "L4";

    /// <summary>
    /// Start the game
    /// </summary>
    public void Start() {
        var index = PlayerPrefs.GetInt(SelectPanel.PLAYER_PREFS_KEY, -1);
        if (index < 0) {
            Debug.LogWarning("No player selected");
        } else {
            Debug.Log($"Selected player index: {index}");
        }
    }

    /// <summary>
    /// Back to the main menu
    /// </summary>
    public void Back() {
        SceneManager.LoadScene(SCENE_NAME);
    }
}
