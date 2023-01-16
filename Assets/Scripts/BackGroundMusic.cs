using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    public static BackGroundMusic instance;
    AudioSource ses; 
    public AudioClip Music; 
 
    void Start ()
    {
        ses= GetComponent<AudioSource> ();
        ses.clip=Music;
        ses.Play();
    }

    void Awake(){
        if(instance !=null){
            Destroy(gameObject);
        }
        else{
            instance=this;
            DontDestroyOnLoad(this.gameObject);
        }
 }
}
