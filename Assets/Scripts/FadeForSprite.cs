using UnityEngine;
using UnityEngine.UI;

public class FadeForSprite:MonoBehaviour {
    public enum SpriteFadeType {
        Out,
        In,
    };
    public SpriteRenderer sprite;
    public float Value = 0.0f;
    public float MaxValue = 1.0f;
    public bool Fadeing = true;
    public SpriteFadeType FadeType = SpriteFadeType.In;
    public float FadeTime = 1.0f;

    // Update is called once per frame
    void Update() {
        if (Fadeing) {

            switch (FadeType) {
                case SpriteFadeType.Out:
                    Value -= Time.deltaTime / FadeTime * MaxValue;
                    break;
                case SpriteFadeType.In:
                    Value += Time.deltaTime / FadeTime * MaxValue;
                    break;
            }
            if (Value < 0.0f)
                Value = 0.0f;
            if (Value > MaxValue)
                Value = MaxValue;
            if (sprite) {
                Color color = sprite.color;
                color.a = Value;
                sprite.color = color;
            } else {
                if (this.gameObject.GetComponent<SpriteRenderer>()) {
                    Color color = this.gameObject.GetComponent<SpriteRenderer>().color;
                    color.a = Value;
                    this.gameObject.GetComponent<SpriteRenderer>().color = color;
                }
            }
        }
    }

    //戻り値 true フェードイン済み
    public bool GetFadeIn() {
        if ((Value == MaxValue) && (FadeType == SpriteFadeType.In))
            return true;
        return false;
    }
    //戻り値 true フェードアウト済み
    public bool GetFadeOut() {
        if ((Value == 0.0f) && (FadeType == SpriteFadeType.Out))
            return true;
        return false;
    }
    //フェードインする
    public void StartFadeIn() {
        FadeType = SpriteFadeType.In;
        Fadeing = true;
    }
    //フェードアウトする
    public void StartFadeOut() {
        FadeType = SpriteFadeType.Out;
        Fadeing = true;
    }
    //ブレンドの値を変える(0 ~ 1)
    public void SetFade(float FadeValue) {
        Value = FadeValue;
    }

}