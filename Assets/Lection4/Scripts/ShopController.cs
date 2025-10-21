using TMPro;
using UnityEngine;

/// <summary>
/// Represents a shop controller
/// </summary>
public class ShopController : MonoBehaviour {

    /// <summary>
    /// Balance of the shop
    /// </summary>
    [SerializeField]
    float _balance = 1000f;

    /// <summary>
    /// Text component to display the shop balance
    /// </summary>
    [SerializeField]
    TextMeshProUGUI _balanceText = null;

    /// <summary>
    /// Array of shop items
    /// </summary>
    [SerializeField]
    ShopItemController[] _shopItems = null;

    /// <summary>
    /// Initializes the shop controller
    /// </summary>
    void Start() {
        _balanceText.SetText($"Balance: ${_balance}");
        var index = 0;
        foreach (var item in _shopItems) {
            var price = Random.Range(10, 100);
            item.Init($"Item {index++}", price, this);
        }
    }

    /// <summary>
    /// Buys a shop item
    /// </summary>
    /// <param name="data">Data of the shop item to buy</param>
    public void BuyItem(ShopItemData data) {
        if (data.Price > _balance) {
            Debug.Log("Not enough money");
            return;
        }
        _balance -= data.Price;
        _balanceText.SetText("Balance: ${0}", _balance);
        Debug.Log($"Buy {data.Title} for ${data.Price}");
    }
}
