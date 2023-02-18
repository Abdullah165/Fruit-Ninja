using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public List<GameObject> fruitsAndBombsList = new List<GameObject>();
    private float timer = 0f;
    private float spawnRate = 3.5f;

    private void Update()
    {
        spawnRate = Random.Range(1.5f, 4f);
        timer += Time.deltaTime;
        if (timer > spawnRate)
        {
            for (int index = 0; index < Random.Range(1, fruitsAndBombsList.Count); index++)
            {
                Instantiate(fruitsAndBombsList[index], transform);
            }
            timer = 0f;
        }
    }
}
