using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChunkPlacer : MonoBehaviour
{
    public Transform player; //Гравець
    public Chunk[] chunksPrefabs;
    public Chunk FirstChunk;

    private List<Chunk> spawnedChunks = new();

    void Start()
    {
        spawnedChunks.Add(FirstChunk);
    }

    void Update()
    {
        if (player.position.x < spawnedChunks[^1].End.position.x + 80)
        {
            SpawnChunk();
        }
    }

    private void SpawnChunk()
    {
        Chunk newChunk = Instantiate(GetRandomChunk());
        //Від позиції End останнього заспавненого чанку віднімаємо локальну позицію початку нового чанку
        newChunk.transform.position = spawnedChunks[^1].End.position - newChunk.Begin.localPosition;
        spawnedChunks.Add(newChunk);

        if(spawnedChunks.Count > 3)
        {
            Destroy(spawnedChunks[0].gameObject);
            spawnedChunks.RemoveAt(0);
        }
    }

    private Chunk GetRandomChunk()
    {
        List<float> chances = new();
        for (int i = 0; i < chunksPrefabs.Length; i++)
            chances.Add(chunksPrefabs[i].ChanceFromDistance.Evaluate(player.transform.position.z));

        float value = Random.Range(0, chances.Sum());
        float sum = 0;
        for (int i = 0; i < chances.Count; i++)
        {
            sum += chances[i];
            if (value < sum) return chunksPrefabs[i]; 
        }
        return chunksPrefabs[^1];
    }
}
