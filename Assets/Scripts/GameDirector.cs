using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;



public class GameDirector : MonoBehaviour {
  GameObject timeText;
  public float time = 60.0f;
  GameObject generator;

  //float[] fliesTimer;
  //public FliesGenerator fliesGenerator;




  void Start() {
    this.generator = GameObject.Find("FliesGenerator");
    this.timeText = GameObject.Find("Time");

    //if (!generator) {//警告
    //  Debug.Log("Warning : \"FliesGenrator\" not found.");
    //}
    //if (fliesGenerator) {
    //  fliesGenerator.CreateAllFlies();
    //}else{//エラー
    //  Debug.Log("Error : \"fliesGenerator\" is null.");
    //}

  }
	
	void Update () {
    //時間経過
        this.time -= Time.deltaTime;
    //Score画面へ
    if (this.time < 0) {
      this.time = 0;
      this.generator.GetComponent<FliesGenerator>().SetParameter(
          Mathf.Infinity, 0, 0, 0, 0);
      SceneManager.LoadScene("Result");
    }


    //少数第二位まで表記
    this.timeText.GetComponent<Text>().text =
      this.time.ToString("F2");
  }
}
