using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FliesControllerL:FlyBase {
    public float time;
    GameObject fliesGene;
    Rigidbody2D rd;

    void Start() {
        fliesGene = GameObject.FindWithTag("Generator");
        rd = GetComponent<Rigidbody2D>();
        //score += 250;
    }

    void Update() {

        //大バエの移動速度、移動範囲
        var s = new Vector2(Random.Range(0.1f,-0.1f),Random.Range(0.1f,-0.1f));
        transform.Translate(s);

        if ((this.gameObject.transform.position.x <= -10) || (this.gameObject.transform.position.x >= 10)) {
            Destroy(this.gameObject);
            fliesGene.SendMessage("destroyFlieL");

        } else if ((this.gameObject.transform.position.y <= -5) || (this.gameObject.transform.position.y >= 5)) {
            Destroy(this.gameObject);
            fliesGene.SendMessage("destroyFlieL");
        }
        transform.position = new Vector2(Mathf.Clamp(this.gameObject.transform.position.x,-9.0f,9.0f),
          Mathf.Clamp(this.gameObject.transform.position.y,-4.0f,4.0f));
    }
}