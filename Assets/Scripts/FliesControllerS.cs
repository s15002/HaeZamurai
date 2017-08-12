using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliesControllerS:FlyBase {
  public float time;
  GameObject fliesGene;

  void Start() {

        fliesGene = GameObject.FindWithTag("Generator");
        //score = 300;
  }

  void Update() {
    
    //小バエの移動速度、移動範囲
      var s = new Vector2(Random.Range(0.2f,-0.2f), Random.Range(0.2f,-0.2f));
    transform.Translate(s);

    if ((this.gameObject.transform.position.x <= -10) || (this.gameObject.transform.position.x >= 10)) {

      Destroy(this.gameObject);
      fliesGene.SendMessage("destroyFlieS");

    } else if ((this.gameObject.transform.position.y <= -5) || (this.gameObject.transform.position.y >= 5)) {
      Destroy(this.gameObject);
      fliesGene.SendMessage("destroyFlieS");
    }
    transform.position = new Vector2(Mathf.Clamp(this.gameObject.transform.position.x, -9.0f, 9.0f),
      Mathf.Clamp(this.gameObject.transform.position.y, -4.0f, 4.0f));
  }
}
