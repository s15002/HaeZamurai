using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliesGenerator:MonoBehaviour {
  public GameObject FliesM;
  public GameObject FliesS;
  public GameObject FliesL;

  //public int fliesMPreProductionAmout = 10;
  //public int fliesSPreProductionAmout = 5;
  //public int fliesLPreProductionAmout = 5;
  
  //ラスト10秒間は生成しない
  //ゲームの時間が60秒間なので50秒の間は生成できる
  //public float CreatableTime = 50.0f;//ハエを生成できる時間

  float span = 1.0f;
  float delta = 0;
  float middle = 5;
  float small = 8;
  float big = 10;
  private int flie = 0;

  List<FlyBase> fliesList = new List<FlyBase>();//ハエのリスト

  //全てのサイズのハエを生成する
  //public void CreateAllFlies() {
  //  //Mサイズ
  //  CreateFlies(fliesMPreProductionAmout,FliesM);
  //  //Sサイズ
  //  CreateFlies(fliesSPreProductionAmout,FliesS);
  //  //Lサイズ
  //  CreateFlies(fliesLPreProductionAmout,FliesL);
  //}

  //ハエを生成する
  //void CreateFlies( int productionAmout , GameObject prefab ) {
  //  GameObject newGameObject;
  //  FlyBase newFly;
  //  for (int i = 0; i < productionAmout; ++i) {
  //    newGameObject = Instantiate(prefab) as GameObject;
  //    newFly = newGameObject.GetComponent<FlyBase>();
  //    if (newFly) {//生成成功
  //      //生成座標と無効時間を設定する
  //      float x = Random.Range(-8.0f,9.0f);
  //      float y = Random.Range(-4.0f,5.0f);
  //      newGameObject.transform.position = new Vector3(x,y,0);
  //      newFly.SetDisableTime(CreatableTime * i / fliesMPreProductionAmout);
        
  //      fliesList.Add(newFly);

  //    } else {//ハエに対応してない

  //      Destroy(newGameObject);
  //      Debug.Log("Warning : \"" + prefab.name + "\" is not fly.");
  //      break;
  //    }
  //  }
  //}
  //ハエジェネのハエ数出力
  public int Getflie() {
    return flie;
  }

  public void SetParameter(float span,float speed,int middle,int small,int big) {
    this.span = span;
    this.middle = middle;
    this.small = small;
    this.big = big;
  }

  void Update() {
    ////ハエの無効時間を減らしていく
    //for ( int i = 0; i < fliesList.Count; ++ i) {
    //  if (fliesList[i]) {
    //    fliesList[i].SubDisableTime(Time.deltaTime);
    //  } else {
    //    fliesList.RemoveAt(i);
    //  }
    //}

    this.delta += Time.deltaTime;

    if (this.delta > this.span) {

      this.delta = 0;
      GameObject Flies;
      if (flie <= 4) {

        //1～10までの数を取って上のmiddleを中央で取って半々
        int dice = Random.Range(1,11);

        if (dice <= this.middle) {
          //1～5までは中バエ
          Flies = Instantiate(FliesM) as GameObject;
          flie++;

          //範囲
          float x = Random.Range(-8.0f,9.0f);
          float y = Random.Range(-4.0f,5.0f);
          Flies.transform.position = new Vector3(x,y,0);

          //６～１０までは小バエ
        } else if (this.middle < dice && this.small <= dice) {
          Flies = Instantiate(FliesS) as GameObject;
          flie++;



          //範囲
          float x = Random.Range(-8.0f,9.0f);
          float y = Random.Range(-4.0f,5.0f);
          Flies.transform.position = new Vector3(x,y,0);

        } else if (this.small < dice && this.big <= dice) {

          Flies = Instantiate(FliesS) as GameObject;
          flie++;

          //範囲
          float x = Random.Range(-8.0f,9.0f);
          float y = Random.Range(-4.0f,5.0f);
          Flies.transform.position = new Vector3(x,y,0);

        }
      }
    }

  }

  public void destroyFlieS() {
    flie--;
  }

  public void destroyFlieM() {
    flie--;
  }

  public void destroyFlieL() {
    flie--;
  }
}