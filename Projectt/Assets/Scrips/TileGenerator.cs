using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public GameObject[] tilePrefab;
    private List<GameObject> activeTiles = new List<GameObject>();
    private float spawnPos;
    private float tileLenght = 100;

    [SerializeField] private Transform player;
    private int StartTiles = 6;
    void Start()
    {
        for(int i = 0; i < StartTiles; i++)
        {
            SpawnTile(Random.Range(0, tilePrefab.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.z - 60 > spawnPos - (StartTiles * tileLenght))
        {
            SpawnTile(Random.Range(0, tilePrefab.Length));
            DeleteTile();
        }
    }
    private void SpawnTile(int tileIndex)
    {
        GameObject nextTile = Instantiate(tilePrefab[tileIndex], transform.forward * spawnPos, transform.rotation);
        activeTiles.Add(nextTile);
        spawnPos += tileLenght;
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
