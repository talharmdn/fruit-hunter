using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text point;
    public TMP_Text tpoint;
    public TMP_Text health;

    
    void Update()
    {
        point.text="Points: " +(int)Hareket.point;
        tpoint.text="Top Point: "+(int)Hareket.top_point;
        health.text="Health: "+(int)Hareket.lives;
    }
}
