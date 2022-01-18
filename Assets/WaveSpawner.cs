using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Wave{
    public string waveName;
    public int numberOfRubbish;
    public GameObject[] typeOfRubbish;
    public float timeBetweenWaves;

}
public class WaveSpawner : MonoBehaviour
{
    public Wave[] waves;
    public  Transform[] spawnPoints;
    private Wave currentWave;
    private int currentWaveNumber;
    private bool canSpawn=true;
    private float nextSpawnTime;
     void Update(){
        currentWave=waves[currentWaveNumber];
        SpawnWave();
        GameObject[] totalRubbish= GameObject.FindGameObjectsWithTag("Rubbish");
        if(totalRubbish.Length==0&&!canSpawn){
            currentWaveNumber++;
            canSpawn=true;
        }
    }
    void SpawnWave(){
        if (canSpawn&&nextSpawnTime<Time.time)
        {
        GameObject randomRubbish=currentWave.typeOfRubbish[Random.Range(0,currentWave.typeOfRubbish.Length)];
        Transform randomPoint = spawnPoints[Random.Range(0,spawnPoints.Length)];
        Instantiate(randomRubbish,randomPoint.position,Quaternion.identity);
        currentWave.numberOfRubbish--;
        nextSpawnTime=Time.time+currentWave.timeBetweenWaves;
        }
        if(currentWave.numberOfRubbish==0)
        {
            canSpawn=false;
        }
    }

}
