using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Mサイズのハエ
public class FliesControllerM:FlyBase {
    public float time;
    GameObject fliesGene;

    void Start() {
        fliesGene = GameObject.FindWithTag("Generator");
        //score = 100;
    }


    void Update() {

        //中バエの移動速度、移動範囲
        var s = new Vector2(Random.Range(0.1f,-0.1f),Random.Range(0.1f,-0.1f));
        transform.Translate(s);

        if ((this.gameObject.transform.position.x <= -10) || (this.gameObject.transform.position.x >= 10)) {
            Destroy(this.gameObject);
            fliesGene.SendMessage("destroyFlieM");

        } else if ((this.gameObject.transform.position.y <= -5) || (this.gameObject.transform.position.y >= 5)) {
            Destroy(this.gameObject);
            fliesGene.SendMessage("destroyFlieM");

        }

        transform.position = new Vector2(Mathf.Clamp(this.gameObject.transform.position.x,-9.0f,9.0f),
          Mathf.Clamp(this.gameObject.transform.position.y,-4.0f,4.0f));
    }
}