using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectPrefabs;
    [SerializeField] private float distance = 5f;
    private Transform player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        foreach (GameObject objectPrefab in objectPrefabs)
        {
            Vector3 randomPosition = GenerateRandomPositionInsideSphere(distance);
            GameObject instantiatedObject = Instantiate(objectPrefab, randomPosition, Quaternion.identity);
            instantiatedObject.transform.LookAt(player);
            yield return new WaitForSeconds(1f);
        }
    }

    private Vector3 GenerateRandomPositionInsideSphere(float sphereRadius)
    {
        Vector3 randomPosition;
        do
        {
            float x = Random.Range(0, sphereRadius);
            float y = Random.Range(0, sphereRadius);
            float z = Random.Range(0, sphereRadius);

            x += player.position.x;
            y += player.position.y;
            z += player.position.z;

            randomPosition = new Vector3(x, y, z);
        } while (Vector3.Distance(randomPosition, player.position) > sphereRadius);

        return randomPosition;
    }
}
