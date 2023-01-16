using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KayitAl : MonoBehaviour
{   
    private float old_our_time; 

    private float old_our_time1; 

    private int SceneIndex;
    public void start(){
      old_our_time=PlayerPrefs.GetFloat(nameof(old_our_time));
      old_our_time1=PlayerPrefs.GetFloat(nameof(old_our_time1));
      SceneIndex=PlayerPrefs.GetInt(nameof(SceneIndex));
    }

    public void SaveGame()
    {
         if(SceneManager.GetActiveScene().buildIndex == 1 && old_our_time1<Zaman.our_time1 && old_our_time==PlayerPrefs.GetFloat(nameof(old_our_time)) ){
            PlayerPrefs.SetFloat(nameof(old_our_time1),Zaman.our_time1);
            PlayerPrefs.SetInt(nameof(SceneIndex),SceneManager.GetActiveScene().buildIndex);
         }

         else if(SceneManager.GetActiveScene().buildIndex == 2 && old_our_time<Bitis.our_time){
             PlayerPrefs.SetFloat(nameof(old_our_time),Bitis.our_time);
             PlayerPrefs.SetInt(nameof(SceneIndex),SceneManager.GetActiveScene().buildIndex);
         }
    }
}
