using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    // Prefab을 받아올 변수 선언
    public GameObject spikes;
    // 리스폰 시간
    public float SpawnTime = 3f;
    // 타이머
    float timer = 0;
    
    void Start(){
        
    }

    void Update(){
        timer += Time.deltaTime;
        if(timer > SpawnTime){
            GameObject spawnspike = Instantiate(spikes);
            spawnspike.transform.position = new Vector3(5, Random.Range(-1.5f, 1.5f), 0);
            Destroy(spawnspike, 10.0f);

            timer = 0;
        }
    }
}
