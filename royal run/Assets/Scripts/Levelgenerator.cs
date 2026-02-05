using UnityEngine;

public class Levelgenerator : MonoBehaviour
{
    [SerializeField] GameObject ChunkLoader;
    [SerializeField] int StartingChunkAmount = 12;
    [SerializeField] Transform Chunkparent;
    [SerializeField] float Chunklenth = 10f;
    private void Start()
    {
        for (int i = 0; i < StartingChunkAmount; i++)
        {
            float spawnpointz;

            if (i == 0)
            {
                spawnpointz = transform.position.z;
            }
            else
            {
                spawnpointz = transform.position.z + (i * Chunklenth);
            }
            Vector3 ChunkSpawnpos = new Vector3(transform.position.x, transform.position.y, spawnpointz);

            Instantiate(ChunkLoader, ChunkSpawnpos, Quaternion.identity, Chunkparent);
        }

    }
}
