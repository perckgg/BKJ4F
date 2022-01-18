using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Wave_fish{
    public string waveName;
    public int numberOfFish;
    public GameObject[] typeOfFish;
    public float timeBetweenWaves;
  

}
public class FishSpawner : MonoBehaviour
{
    public Wave_fish[] waves;
    public  Transform[] spawnPoints;
    private Wave_fish currentWave;
    private int currentWaveNumber;
    private bool canSpawn=true;
    private float nextSpawnTime;
     void Update(){
        currentWave=waves[currentWaveNumber];
        SpawnWave();
        GameObject[] totalFish= GameObject.FindGameObjectsWithTag("BakaFish");
        if(totalFish.Length==0&&!canSpawn&&currentWaveNumber+1!=waves.Length){
            SpawnNextWave();
        }
    }
    void SpawnNextWave(){
        //Spawn next wave;
            currentWaveNumber++;
            canSpawn=true;
    }
    void SpawnWave(){
        if (canSpawn&&nextSpawnTime<Time.time)
        {
        GameObject randomFish=currentWave.typeOfFish[Random.Range(0,currentWave.typeOfFish.Length)];
        Transform Point = spawnPoints[Random.Range(0,spawnPoints.Length)];
        Instantiate(randomFish,Point.position,Quaternion.identity);
        currentWave.numberOfFish--;
        nextSpawnTime=Time.time+currentWave.timeBetweenWaves;
        }
        if(currentWave.numberOfFish==0)
        {
            canSpawn=false;
        }
    }

}
