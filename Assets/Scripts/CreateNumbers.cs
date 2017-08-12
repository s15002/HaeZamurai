using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNumbers:MonoBehaviour {

  public GameObject Img0;
  public GameObject Img1;
  public GameObject Img2;
  public GameObject Img3;
  public GameObject Img4;
  public GameObject Img5;
  public GameObject Img6;
  public GameObject Img7;
  public GameObject Img8;
  public GameObject Img9;

  public void CreateNumberObjects(Vector3 pos,int value,float fontExtend) {
    int v = 0;
    GameObject newObject;
    do {
      v = value % 10;
      value /= 10;
      Debug.Log("CNObject : " + v);
      switch (v) {
        case 0:
          newObject = Instantiate(Img0,pos,Quaternion.Euler(0,0,0));
          newObject.transform.localScale *= fontExtend;
          break;
        case 1:
          newObject = Instantiate(Img1,pos,Quaternion.Euler(0,0,0));
          newObject.transform.localScale *= fontExtend;
          break;
        case 2:
          newObject = Instantiate(Img2,pos,Quaternion.Euler(0,0,0));
          newObject.transform.localScale *= fontExtend;
          break;
        case 3:
          newObject = Instantiate(Img3,pos,Quaternion.Euler(0,0,0));
          newObject.transform.localScale *= fontExtend;
          break;
        case 4:
          newObject = Instantiate(Img4,pos,Quaternion.Euler(0,0,0));
          newObject.transform.localScale *= fontExtend;
          break;
        case 5:
          newObject = Instantiate(Img5,pos,Quaternion.Euler(0,0,0));
          newObject.transform.localScale *= fontExtend;
          break;
        case 6:
          newObject = Instantiate(Img6,pos,Quaternion.Euler(0,0,0));
          newObject.transform.localScale *= fontExtend;
          break;
        case 7:
          newObject = Instantiate(Img7,pos,Quaternion.Euler(0,0,0));
          newObject.transform.localScale *= fontExtend;
          break;
        case 8:
          newObject = Instantiate(Img8,pos,Quaternion.Euler(0,0,0));
          newObject.transform.localScale *= fontExtend;
          break;
        case 9:
          newObject = Instantiate(Img9,pos,Quaternion.Euler(0,0,0));
          newObject.transform.localScale *= fontExtend;
          break;
      }
      pos.x -= 1;
    } while (value > 0);
  }
}
