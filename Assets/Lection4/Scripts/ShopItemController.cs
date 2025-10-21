using TMPro;
using UnityEngine;

/// <summary>
/// Represents the data for a shop item
/// </summary>
public struct ShopItemData {
    public float Price;
    public string Title;
}

/// <summary>
/// Represents a shop item
/// </summary>
public class ShopItemController : MonoBehaviour {

    /// <summary>
    /// Price of the shop item
    /// </summary>
    ShopItemData _data = new ShopItemData();

    /// <summary>
    /// Reference to the shop controller
    /// </summary>
    ShopController _controller = null;

    /// <summary>
    /// Text component to display the title of the shop item
    /// </summary>
    [SerializeField]
    TextMeshProUGUI _title = null;

    /// <summary>
    /// Text component to display the price of the shop item
    /// </summary>
    [SerializeField]
    TextMeshProUGUI _price = null;

    /// <summary>
    /// Initializes the shop item controller
    /// </summary>
    /// <param name="title">Title of the shop item</param>
    /// <param name="price">Price of the shop item</param>
    /// <param name="controller">Link to the shop controller</param>
    public void Init(string title, float price, ShopController controller) {
        _data.Title = title;
        _data.Price = price;
        _controller = controller;
        _title.SetText(title);
        _price.SetText($"${price}");
    }

    /// <summary>
    /// Buys the shop item
    /// </summary>
    public void Buy() {
        _controller.BuyItem(_data);
    }
}
