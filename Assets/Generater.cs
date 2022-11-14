using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generater : MonoBehaviour
{
    public GameObject obstructionPrefab;    // ��ֹ�
    public Transform spawnPosition;         // ��������
    public GameMgr gameMgr;
    float LevelTime = 3f;                   // �����ð�
    float reSpawnTime = 3f;                 // �����ð�
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        reSpawnTime -= Time.deltaTime;
        // reSpawnTime���� �ݺ�
        if(reSpawnTime <= 0)
        {
            // ��ֹ� ����
            GameObject obstructionClone = Instantiate(obstructionPrefab, spawnPosition.position, spawnPosition.rotation);
            obstructionClone.GetComponent<Rigidbody2D>().velocity = Vector2.left;
            // ��ֹ� y�� (-1,1)����
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
