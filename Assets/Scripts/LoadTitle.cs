using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadTitle : MonoBehaviour {
  GameObject scoreDire;


  void Start () {
    scoreDire = GameObject.FindWithTag("GameController");
  }

  void Update () {
   
  }

  public void OnClick() {
    //ボタンクリックによるクリックでシーン遷移
    SceneManager.LoadScene("Title");
    scoreDire.SendMessage("loadTitle");
  }


}
