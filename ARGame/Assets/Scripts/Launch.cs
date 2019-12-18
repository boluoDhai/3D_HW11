using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{

    public GameObject rocket;
    protected float passed_time;
    protected float accelerate;
    protected float start_time;

    // Start is called before the first frame update
    void Start(){
        rocket = GameObject.Find("AtomRocket");
        passed_time = 0;
        accelerate = 3.0f;
        start_time = 10.0f;
    }

    // Update is called once per frame
    void Update(){
        passed_time += Time.deltaTime;
        if(passed_time > start_time) {
            Vector3 pos = rocket.transform.position;
            pos.z += accelerate * (passed_time - start_time) * Time.deltaTime;
            rocket.transform.position = pos;
        }
    }
}
