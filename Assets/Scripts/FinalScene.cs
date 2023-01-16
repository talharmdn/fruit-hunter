using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class FinalScene : MonoBehaviour
{
  public static int myvalue;

  public void Update(){
    if(Zaman.our_time1<=Bitis.our_time){
      SceneManager.LoadSceneAsync("YeniSahne");
      if(SceneManager.GetActiveScene().buildIndex == 2  ){ 
        BackGroundMusic.instance.GetComponent<AudioSource>().Play();
      }
    }
  }
}


