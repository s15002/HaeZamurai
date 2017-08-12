using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopstickController:MonoBehaviour {

    [SerializeField]
    private float waitTime = 0.3f;

    private BoxCollider2D flyKill;
    private WaitForSeconds wait;

    //ハエを殺すときに使用
    //To do: Unity Event しない
    public delegate void KillCallback();
    public KillCallback killcallback;

    void Start() {
        flyKill = GetComponent<BoxCollider2D>();
        wait = new WaitForSeconds(waitTime);
    }

    public void setCallBack(KillCallback kc) {
        killcallback = kc;
    }

    public IEnumerator killJudg() {

        if (killcallback != null) {
            killcallback();
        }
        yield return wait;
    }
}
