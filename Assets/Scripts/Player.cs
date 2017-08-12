using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player:MonoBehaviour {

    public List<GameObject> FlyType = new List<GameObject>();
    public GameObject chopstickMove;

    ChopstickController ChopstickCR;

    Vector3 position;

    void Start() {
        ChopstickCR = this.GetComponentInChildren<ChopstickController>();
    }

    void Update() {

        //スクリーンから見たマウスの座標を得る
        Vector2 tapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //マウスの位置を取得
        Vector3 mousePos = Input.mousePosition;

        //上記をゲーム内ポジションに変換
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);

        //箸を移動
        this.transform.position = objPos;

        //箸の移動範囲    
        this.transform.position = new Vector2(Mathf.Clamp(this.gameObject.transform.position.x,-9.0f,9.0f),
          Mathf.Clamp(this.gameObject.transform.position.y,-4.0f,4.0f));

        if (Input.GetButtonDown("Fire1")) {
            chopstickMove.transform.Rotate(0,0,+45);
            StartCoroutine(ChopstickCR.killJudg());
        }

        if (Input.GetButtonUp("Fire1")) {
            chopstickMove.transform.Rotate(0,0,-45);
        }
    }
}