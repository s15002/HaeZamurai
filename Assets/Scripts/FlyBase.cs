using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBase : MonoBehaviour {

  public bool active = false;//ハエのアクティブ状態
  public int score = 100;//ハエのスコア
  float DisableTime = 0.0f;//ハエが非表示になっている時間
  public CreateNumbers scoreNumFont;//得点の数値用フォント
  GameObject director;

  private void Start() {
    this.director = GameObject.Find("GameDirector");
  }



  //無効時間を設定する
  public void SetDisableTime(float time) {
    DisableTime = time;
    SetActiveWithDisableTime();
  }

  //無効時間を減算する
  public void SubDisableTime(float subTime) {
    DisableTime -= subTime;
    SetActiveWithDisableTime();
  }

  //無効時間の残量がなくなったらハエを動かす。
  public virtual void SetActiveWithDisableTime() {
    if (DisableTime > 0.0f && active == false ) {
      active = false;
      this.gameObject.SetActive(false);
    } else {
      DisableTime = 0.0f;
      active = true;
      this.gameObject.SetActive(true);
    }
  }

  void OnCollisionColliderHit (Collision hit) {
    if (hit.gameObject.tag == "Player"){
      Destroy(this.gameObject);
      scoreNumFont.CreateNumberObjects(new Vector3(transform.position.x,transform.position.y,0),score,0.2f);
    }
  }
}
