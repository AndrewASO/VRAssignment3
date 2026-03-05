using UnityEngine;
using UnityEngine.UI;

public class CSpriteSwap : MonoBehaviour {

    public Image circleImage;
    public Sprite normalSprite;
    public Sprite hoverSprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {
        if(circleImage == null) {
            circleImage = GetComponent<Image>();
        }
    }

    public void SetNormalSprite() {
        if(circleImage != null && normalSprite != null){
            circleImage.sprite = normalSprite;
        }
    }

    public void SetHoverSprite() {
        if (circleImage != null && hoverSprite != null) {
            circleImage.sprite = hoverSprite;
        }
    }
}
