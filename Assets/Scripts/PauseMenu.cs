using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class PauseMenu : MonoBehaviour
{


    public static bool belirleyici;
    public GameObject Menu;

    public GameObject image;


    public void Pause() {
        Menu.SetActive(true);
        image.SetActive(true);
        Time.timeScale=0f;
        belirleyici=true;
    }

    public void Resume() {
        Menu.SetActive(false);
        image.SetActive(false);
        Time.timeScale=1f;
        belirleyici=false;
    }

    public void restart(){
        SceneManager.LoadSceneAsync(1);
        Time.timeScale=1f;
        Zaman.our_time1=40;
        Hareket.point=0;
        Hareket.lives=3;
        Destroy(this.gameObject);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
        
            if(belirleyici) {
                Resume();
             }
            else{
                Pause();
            } 
        }
    }

   public void GeriDon(){
        SceneManager.LoadSceneAsync("SampleScene");
        Time.timeScale=1f;
    }
} 




