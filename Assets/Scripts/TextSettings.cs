using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSettings : MonoBehaviour {

    float aliveTime = 2;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        aliveTime -= Time.deltaTime;
        if (aliveTime <= 0) {
            Destroy(this.gameObject);
        }
    }
}
