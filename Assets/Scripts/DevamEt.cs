using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevamEt : MonoBehaviour
{

   private int SceneIndex;
   private float old_our_time;

   private float old_our_time1;
   public void Start()
   {
      SceneIndex=PlayerPrefs.GetInt(nameof(SceneIndex));
      old_our_time=PlayerPrefs.GetFloat(nameof(old_our_time));
      old_our_time1=PlayerPrefs.GetFloat(nameof(old_our_time1));
   }

   public void Continue(){
      if(SceneIndex ==1){
         SceneManager.LoadSceneAsync(PlayerPrefs.GetInt(nameof(SceneIndex)));
         Zaman.our_time1=old_our_time1;
     }
      else if(SceneIndex ==2){
         SceneManager.LoadSceneAsync(PlayerPrefs.GetInt(nameof(SceneIndex)));
         Bitis.our_time=old_our_time;
      }
      else{
         Debug.Log("Game is not found");
     }

        
   }

}

 
