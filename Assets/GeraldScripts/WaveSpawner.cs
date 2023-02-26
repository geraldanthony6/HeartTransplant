using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    [SerializeField]private GameObject[] enemyArray;
    [SerializeField]private float room1minX;
    [SerializeField]private float room1maxX;
    [SerializeField]private float room1minY;
    [SerializeField]private float room1maxY;
    [SerializeField]private float room2minX;
    [SerializeField]private float room2maxX;
    [SerializeField]private float room2minY;
    [SerializeField]private float room2maxY;
    [SerializeField]private float room3minX;
    [SerializeField]private float room3maxX;
    [SerializeField]private float room3minY;
    [SerializeField]private float room3maxY;
    [SerializeField]private float room4minX;
    [SerializeField]private float room4maxX;
    [SerializeField]private float room4minY;
    [SerializeField]private float room4maxY;
    private float curMinX;
    private float curMaxX;
    private float curMinY;
    private float curMaxY;
    [SerializeField]private bool spawnWave = false;
    [SerializeField]private float waveTimer = 0;
    [SerializeField]private int waveCount;
    // Start is called before the first frame update
    void Start()
    {
        curMinX = room1minX;
        curMaxX = room1maxX;
        curMinY = room1minY;
        curMaxY = room1maxY;
    }

    // Update is called once per frame
    void Update()
    {
        if(!spawnWave && waveTimer <= 0){
            StartCoroutine(SpawnWave(10));
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
    }

    public float GetWaveTimer(){
        return waveTimer;
    }

    public int GetWaveCount(){
        return waveCount;
    }
}
