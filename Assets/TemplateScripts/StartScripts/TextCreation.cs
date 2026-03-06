using UnityEngine;
using TMPro;

public class TextCreation : MonoBehaviour {
    public TextMeshProUGUI text;

    public void ToggleText() {
        text.gameObject.SetActive(!text.gameObject.activeSelf);
    }
}
