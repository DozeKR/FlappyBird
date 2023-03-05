using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // 장애물이 나오는 시간 조정 변수
    public float speed = 1f;

    void Start(){
        
    }

    void Update(){
        // transform.position = transform컴포넌트의 position값
        // Vector3.left = (-1,0,0) 
        // 프레임 단위는 환경마다 다르기 때문에 Time.deltaTime을 활용한다.
        transform.position += Vector3.left * speed * Time.deltaTime;
        Debug.Log(transform.position);
    }

}
