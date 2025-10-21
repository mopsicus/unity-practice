using TMPro;
using UnityEngine;

/// <summary>
/// Volume option controller
/// /// </summary>
public class VolumeOption : MonoBehaviour {

    /// <summary>
    /// Reference to the volume text
    /// </summary>
    [SerializeField]
    TextMeshProUGUI _volumeText = null;

    /// <summary>
    /// Callback on volume slider change
    /// </summary>
    /// <param name="value">Volume value</param>
    public void OnVolumeChange(float value) {
        _volumeText.SetText("Volume: {0}", value);
    }
}
