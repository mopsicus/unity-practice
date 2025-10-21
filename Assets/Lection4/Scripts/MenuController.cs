using TMPro;
using UnityEngine;

/// <summary>
/// Controller for the game menu
/// </summary>
public class MenuController : MonoBehaviour {

    /// <summary>
    /// Reference to the game menu
    /// </summary>
    [SerializeField]
    GameObject _gameMenu = null;

    /// <summary>
    /// Reference to the options menu
    /// </summary>
    [SerializeField]
    GameObject _optionsMenu = null;

    /// <summary>
    /// Reference to the shop menu
    /// </summary>
    [SerializeField]
    GameObject _shopMenu = null;

    /// <summary>
    /// Reference to the lobby menu
    /// </summary>
    [SerializeField]
    GameObject _lobbyMenu = null;

    /// <summary>
    /// Reference to the main menu
    /// </summary>
    [SerializeField]
    GameObject _menu = null;

    /// <summary>
    /// Opens the specified menu
    /// </summary>
    /// <param name="screen">Screen name</param>
    public void Open(string screen) {
        _menu.SetActive(false);
        _optionsMenu.SetActive(false);
        _gameMenu.SetActive(false);
        _shopMenu.SetActive(false);
        _lobbyMenu.SetActive(false);
        switch (screen) {
            case "game":
                _gameMenu.SetActive(true);
                break;
            case "options":
                _optionsMenu.SetActive(true);
                break;
            case "shop":
                _shopMenu.SetActive(true);
                break;
            case "lobby":
                _lobbyMenu.SetActive(true);
                break;
            default:
                _menu.SetActive(true);
                break;
        }
    }

    /// <summary>
    /// Simulates the exit process
    /// </summary>
    public void Exit() {
        Debug.Log("Exit");
    }
}
