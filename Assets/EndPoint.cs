using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndPoint : MonoBehaviour
{
 
    void Start(){
        GetComponent<Text>().text = "SCORE: " + Point.point.ToString();
    }

}
