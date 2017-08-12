using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class ScoreDirector : GameDirector {
  GameObject scoreText;
  static  int score;

  public CreateNumbers scoreNumFont;//得点の数値用フォント

  void Example() {
    //スコアの保存
    PlayerPrefs.SetInt("score", 0);

    //スコアを表示
    print(PlayerPrefs.GetInt("score"));

  }


  public void GetFliesM() {
    //中バエのスコア
    score += 100;
  }


  public void GetFliesS() {
    //小バエのスコア
    score += 300;
  }

  void Start () {
    //スコアオブジェクトの発見
    this.scoreText = GameObject.Find("Score");
  }

  void Update () {//スコア表記
    this.scoreText.GetComponent<Text>().text =
    score.ToString() + " point";
  }

  public void loadTitle() {
    score = 0;
  }
}
