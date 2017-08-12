using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateFont:MonoBehaviour {

    public GameObject FontEnd;

    public void CreateFontObjects(Vector2 pos) {
        GameObject newObject;

        newObject = Instantiate(FontEnd,pos,Quaternion.Euler(0,0,0));
    }

}