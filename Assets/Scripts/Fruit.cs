using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField]
    private float speed= 50.0f;
    void Update()
    {
        transform.Translate(Vector3.down*speed*Time.deltaTime);
        if(transform.position.y < -5f){
            float x= Random.Range(140f,780f);
            transform.position= new Vector3(x, 420, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag=="Sepet"){
            Hareket hareket = other.transform.GetComponent<Hareket>();
            if(hareket != null){
                hareket.addPoint();
            }
            Destroy(this.gameObject);
        }
    }
}
