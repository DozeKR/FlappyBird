using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Rigidbody변수 선언
    Rigidbody2D RB_Player;
    // 점프세기
    public float JumpPower = 5f;

    void Start(){
        RB_Player = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("jump");
            RB_Player.velocity = Vector2.up * JumpPower;
        }
    }

    // 플레이어가 다른 콜리전과 부딪혔을 때 실행
    private void OnCollisionEnter2D(Collision2D other){
        // 최고점수 저장
        if(Point.point > Point.bestpoint){
            Point.bestpoint = Point.point;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
