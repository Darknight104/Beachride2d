using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    public GameObject rock, burger;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRocks());
        StartCoroutine(SpawnBurger());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnRocks()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(4f, 8f));
            Vector3 pos = new Vector3(Random.Range(12f, 15f), -2f, 0);
            Instantiate(rock, pos, Quaternion.identity);
        }
    }
    IEnumerator SpawnBurger()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(6f, 10f));
            Vector3 pos = new Vector3(Random.Range(12f,15f),Random.Range(0f,-2f),0);
            Instantiate(burger, pos, Quaternion.identity);
        }
    }

}