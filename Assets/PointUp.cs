using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointUp : MonoBehaviour
{
    // 한번만 점수를 올리기 위한 변수
    int count = 0;
    private void OnTriggerExit2D(Collider2D other){
        if(count==0){
            Point.point++;
            count++;
        }
    }
}
