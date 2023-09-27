using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int CoinsAmount = 10;
    public AudioSource _AudioSource;
    public GameObject CoinCollectedAudio;
    public GameObject Effects;
    public Collider2D _Collider2D;
    

    public float DespawnInterval = 1f;
    private float despawnTimer;

    private Spawner _spawner;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        _Collider2D = GetComponent<Collider2D>();
        _AudioSource = GetComponent<AudioSource>();

        despawnTimer = DespawnInterval;

        _spawner = FindObjectOfType<Spawner>();
    }

    private void OnMouseOver()
    {
        //Debug.Log("Coins collected " + CoinsAmount);
        //if(_AudioSource != null)
        //_AudioSource.Play();

        if(_spawner != null) 
        {
            //spawner will add points to CoinsCollected;
            _spawner.AddCoin(CoinsAmount);
        }


        if (CoinCollectedAudio != null)
        {
            GameObject.Instantiate(CoinCollectedAudio, transform.position, Quaternion.identity);
        }

        if (Effects != null)
        {
            GameObject.Instantiate(Effects, transform.position, Quaternion.identity);
        }

        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (despawnTimer > 0f)
        {
            despawnTimer -= Time.deltaTime;
        }

        else 
        { 
            Destroy(this.gameObject);
            Debug.Log("Times up, should despawn coin");
        }
    }
}
