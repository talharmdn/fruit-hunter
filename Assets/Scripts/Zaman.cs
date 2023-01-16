using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Zaman : MonoBehaviour
{
    public static float our_time1=40;
    public TMP_Text my_time;

    void Start()
    {
        my_time.text=" "+(int)our_time1;

    }
    
    void Update()
    {
        our_time1 -=Time.deltaTime;
        my_time.text=" " +(int)our_time1;
    }

 
}
