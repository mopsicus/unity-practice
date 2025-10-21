using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controller for the selection player
/// </summary>
public class SelectPanel : MonoBehaviour {

    /// <summary>
    /// Player prefs key for storing selected player
    /// </summary>
    public const string PLAYER_PREFS_KEY = "SelectedPlayer";

    /// <summary>
    /// Name of the scene to load
    /// </summary>
    const string SCENE_NAME = "L4.2";

    /// <summary>
    /// Reference to the player name text fields
    /// </summary>
    [SerializeField]
    TextMeshProUGUI[] _playerNames = new TextMeshProUGUI[3];

    /// <summary>
    /// Reference to the info text field
    /// </summary>
    [SerializeField]
    TextMeshProUGUI _infoText = null;

    /// <summary>
    /// Selects the player
    /// </summary>
    public void Select(int index) {
        PlayerPrefs.SetInt(PLAYER_PREFS_KEY, index);
        PlayerPrefs.Save();
        _infoText.SetText($"You selected {_playerNames[index].text}");
    }

    /// <summary>
    /// Load game scene
    /// </summary>
    public void StartGame() {
        SceneManager.LoadScene(SCENE_NAME);
    }
}
