using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField]private GameObject[] enemyArray;
    public float room1minX;
    public float room1maxX;
    public float room1minY;
    public float room1maxY;
    public float room2minX;
    public float room2maxX;
    public float room2minY;
    public float room2maxY;
    public float room3minX;
    public float room3maxX;
    public float room3minY;
    public float room3maxY;
    public float room4minX;
    public float room4maxX;
    public float room4minY;
    public float room4maxY;
    [SerializeField]private float curMinX;
    [SerializeField]private float curMaxX;
    [SerializeField]private float curMinY;
    [SerializeField]private float curMaxY;
    [SerializeField]private bool spawnWave = false;
    [SerializeField]private float waveTimer = 0;
    [SerializeField]private int waveCount;
    [SerializeField]private int waveAmount;
    // Start is called before the first frame update
    void Start()
    {
        waveAmount = 10;
        curMinX = room1minX;
        curMaxX = room1maxX;
        curMinY = room1minY;
        curMaxY = room1maxY;
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawnWave && waveTimer <= 0){
            StartCoroutine(SpawnWave(waveAmount));
        }

        if(waveTimer > 0){
            waveTimer -= Time.deltaTime;
        }
    }

    IEnumerator SpawnWave(int waveSize){
        spawnWave = true;
        waveCount++;
        yield return new WaitForSeconds(2f);
        for(int i = 0; i < waveSize; i++){
            Instantiate(enemyArray[Random.Range(0, enemyArray.Length)], new Vector2(Random.Range(curMinX, curMaxX), Random.Range(curMinY, curMaxY)), Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        spawnWave = false;
        waveTimer = 10;
        waveAmount += 2;
    }

    public float GetWaveTimer(){
        return waveTimer;
    }

    public int GetWaveCount(){
        return waveCount;
    }

    public void SetCurSpawnRange(float newCurMinX, float newCurMaxX, float newCurMinY, float newCurMaxY){
        curMinX = newCurMinX;
        curMaxX = newCurMaxX;
        curMinY = newCurMinY;
        curMaxY = newCurMaxY;
    }
}
