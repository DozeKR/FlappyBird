using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float jumpPower = 5f;    //점프력 세기   
    public GameMgr gameMgr;

    // 스크립트 활성화 후 Update 직전에 한번만 호출
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }
    // 매 프레임 마다 호출
    void Update()
    {
        if(Input.GetMouseButtonDown (0))
        {
            rb2d.velocity = Vector2.up * jumpPower;
        }
    }

    private void OnTriggerExit2D ( Collider2D collision)
    {
        if(collision.CompareTag("ScorePlus"))
        {
            gameMgr.AddScore();
        }  
    }
    private void OnCollisionEnter2D ( Collision2D collision)
    {
        gameMgr.isGameOver = true;
    }
}
