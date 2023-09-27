using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject CoinPrefab;

    public float DurationLeft = 60f;

    public float SpawnInterval = 1f;


    private float spawnTimer;

    public float minX = -1f;
    public float maxX = -1f;

    public float CoinCollected = 0f;

    public TMP_Text Text;

    private float randomX;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = SpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnTimer > 0) 
        { 
            spawnTimer -= Time.deltaTime;
        }

        else 
        {
            float rand = Random.Range(minX, maxX);

            Vector3 randomPos = new Vector3(rand, 0f, 0f);

            if(CoinPrefab != null) 
            {
                GameObject.Instantiate(CoinPrefab, transform.position + randomPos, transform.rotation);
            }

            Debug.Log("Times up, should spawn silver coin");
            spawnTimer = SpawnInterval;
        }
    }

    public void AddCoin(float amount)
    {
        CoinCollected += amount;
        Debug.Log("Collected coins " + CoinCollected);

        if(Text != null) 
        { 
            Text.text = CoinCollected.ToString();
        }
    }
}
