using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    // 점수 변수
    public static int point = 0;  
    // 최고 점수 변수
    public static int bestpoint = 0;  
   
    void Start(){
        point = 0;
    }

    void Update(){
        GetComponent<Text>().text = point.ToString();
    }
}
