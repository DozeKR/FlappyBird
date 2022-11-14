using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float jumpPower = 5f;    //������ ����   
    public GameMgr gameMgr;

    // ��ũ��Ʈ Ȱ��ȭ �� Update ������ �ѹ��� ȣ��
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }
    // �� ������ ���� ȣ��
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
