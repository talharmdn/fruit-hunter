using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField]
    private float speed= 50.0f;
    private Hareket hareket;
    private float fark;
    void Update()
    {
        transform.Translate(Vector3.down*speed*Time.deltaTime);
        fark=-21f-transform.position.y;
        if(fark==0f){
            float x= Random.Range(140f,780f);
            transform.position= new Vector3(x, 420, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Sepet"){
            Hareket hareket = other.transform.GetComponent<Hareket>();
            if(hareket != null){
                hareket.can();
            }
            Destroy(this.gameObject);
        }
    }
}
