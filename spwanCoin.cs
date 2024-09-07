using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanCoin : MonoBehaviour
{
    public float maxX;
    public float maxZ;
    public GameObject coin;
    void Start()
    {
        InvokeRepeating("spawnball", 1f, 1f);

    }
    void spawnball()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomZ = Random.Range(-maxZ, maxZ);
        Vector3 randomPos = new Vector3(randomX, 0.62f, randomZ);
        Instantiate(coin, randomPos, Quaternion.identity);
    }
}
