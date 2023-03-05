using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestPoint : MonoBehaviour
{
   
    void Start(){
        GetComponent<Text>().text = "BEST: " + Point.bestpoint.ToString();
    }

}
