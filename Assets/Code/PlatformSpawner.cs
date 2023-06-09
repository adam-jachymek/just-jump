using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] public GameObject platform;

    public float waitingForNextSpawn = 8;
    private Vector2 lastPosition;

    void Update()
    {
        waitingForNextSpawn -= Time.deltaTime;

        if ( transform.position.y - lastPosition.y > 2f ) { 
            
            SpawnPlatform();

        }

        Debug.Log(waitingForNextSpawn);
    }
    void SpawnPlatform()
    {
        GameObject clone = Instantiate(platform);

        clone.transform.localScale = Vector2.one * Random.Range(0.5f, 2f);

        Vector2 pos = new Vector2(Random.Range(-2f, 2f), transform.position.y + Random.Range(-1f, 1f));

        lastPosition = pos;

        Instantiate(clone, pos, transform.rotation);
    }
}
