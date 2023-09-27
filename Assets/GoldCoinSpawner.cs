using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoinSpawner : MonoBehaviour
{
    public GameObject CoinPrefab;

    public float GoldCoinSpawnInterval = 1f;

    private float goldCoinSpawnTimer;

    public float minX = -1f;
    public float maxX = -1f;
    // Start is called before the first frame update
    void Start()
    {
        goldCoinSpawnTimer = GoldCoinSpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (goldCoinSpawnTimer > 0)
        {
            goldCoinSpawnTimer -= Time.deltaTime;
        }

        else
        {
            float rand = Random.Range(minX, maxX);

            Vector3 randomPos = new Vector3(rand, 0f, 0f);

            if (CoinPrefab != null)
            {
                GameObject.Instantiate(CoinPrefab, transform.position + randomPos, transform.rotation);
            }

            Debug.Log("Times up, should spawn silver coin");
            goldCoinSpawnTimer = GoldCoinSpawnInterval;
        }
    }
}
