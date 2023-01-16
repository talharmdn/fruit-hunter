using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bitis : MonoBehaviour
{
   public static float our_time=20;
    public TMP_Text my_time;

    void Start()
    {
        my_time.text=" "+(int)our_time;

    }

    
    void Update()
    {
        our_time -=Time.deltaTime;
        my_time.text=" " +(int)our_time;
    }
}
