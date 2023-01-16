using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject Menu;

    public TextMeshProUGUI yazi;
    public int deger;

    public void restart(){
    Time.timeScale=1f;
    SceneManager.LoadSceneAsync("OyunSahnesi");
     
    }
    
    public void GeriDon(){
        if(SceneManager.GetActiveScene ().buildIndex==2){
            SceneManager.LoadSceneAsync("SampleScene"); 
        }
    }

    void Update()
    {
        if(yazi.text==" "+deger){
            Menu.SetActive(true);
            Time.timeScale=0.0001f;
        }
    }

    public void menu(){
        Menu.SetActive(true);
        Time.timeScale=0.0001f;
    }

}
