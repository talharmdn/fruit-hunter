using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

using UnityEngine;

public class Hareket : MonoBehaviour
{
    AudioSource ses;
    public static Hareket objem;
    public static int lives=3;
    public static int point=0;
    public static int top_point=0;
    private GameOver go;
    void Start()
    {   
        if(objem==null){
            objem =this;
            DontDestroyOnLoad(this.gameObject);
        }
        else if(objem!=this.gameObject){
            Destroy(this.gameObject);  
        }     
        ses=GetComponent<AudioSource>();
        go = GameObject.Find("Canvas").GetComponent<GameOver>();

    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) ){
            ses.Play();
        }
    }
   
   void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal")<0)
        {
           transform.position -= new Vector3(3f, 0.0f, 0.0f); 
           
        }
        else if (Input.GetAxis("Horizontal")>0)
        { 
           transform.position += new Vector3(3f, 0.0f, 0.0f); 
        }
    }

    public void can(){
        if(lives>1){
            --lives;
        }
        else{
            Time.timeScale=0.001f;
            SceneManager.LoadSceneAsync(0);
        }
    }

    public void addPoint(){
        point+=5;
        Debug.Log(point);
        if(point>top_point){
            top_point=point;
        }
    }
   
}
