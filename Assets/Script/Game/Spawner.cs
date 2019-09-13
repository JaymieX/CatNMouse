using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> SpawnableObjects;

    public float MinTickTime;
    public float MaxTickTime;

    private float ticks = 0f;
    private float nextTickTime;

    // Start is called before the first frame update
    void Start()
    {
        nextTickTime = Random.Range(MinTickTime, MaxTickTime);
    }

    // Update is called once per frame
    void Update()
    {
        ticks += Time.deltaTime;
        if (ticks >= nextTickTime)
        {
            Spawn();
            nextTickTime = Random.Range(MinTickTime, MaxTickTime);
            ticks = 0f;
        }
    }

    private void Spawn()
    {
        GameObject spawningObject = SpawnableObjects[Random.Range(0, SpawnableObjects.Count - 1)];
        float y = Random.Range(-4f, 4f);
        Vector3 pos = transform.position;
        pos.y += y;

        Instantiate(spawningObject, pos, Quaternion.identity);
    }
}
