using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generater : MonoBehaviour
{
    public GameObject obstructionPrefab;    // 장애물
    public Transform spawnPosition;         // 스폰지점
    public GameMgr gameMgr;
    float LevelTime = 3f;                   // 레벨시간
    float reSpawnTime = 3f;                 // 스폰시간
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        reSpawnTime -= Time.deltaTime;
        // reSpawnTime마다 반복
        if(reSpawnTime <= 0)
        {
            // 장애물 생성
            GameObject obstructionClone = Instantiate(obstructionPrefab, spawnPosition.position, spawnPosition.rotation);
            obstructionClone.GetComponent<Rigidbody2D>().velocity = Vector2.left;
            // 장애물 y축 (-1,1)랜덤
            obstructionClone.transform.position = new Vector3(obstructionClone.transform.position.x,
                                                                Random.Range(-1.0f, 1.0f), 
                                                               obstructionClone.transform.position.z);
            if (gameMgr.ScorePoint() != 0 && gameMgr.ScorePoint() % 10 == 0)
            {
                if(LevelTime > 1f)
                {
                    Debug.Log("d");
                    LevelTime = LevelTime - 0.1f;
                }   
            }

            reSpawnTime = LevelTime;
        } 
    }
}
