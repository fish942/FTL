using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public GameObject[] roomPrefabs;   // All possible room prefabs
    public Transform currentSpawnPoint;

    void Start()
    {
        // Optionally spawn a few rooms at the beginning
        for (int i = 0; i < 5; i++)
        {
            SpawnNextRoom();
        }
    }

    public void SpawnNextRoom()
    {
        int index = Random.Range(0, roomPrefabs.Length);

        // Spawn the room at the current spawn point
        GameObject room = Instantiate(
            roomPrefabs[index],
            currentSpawnPoint.position,
            currentSpawnPoint.rotation
        );

        // Find the EndPoint inside the spawned room
        Transform endPoint = room.transform.Find("EndPoint");

        if (endPoint == null)
        {
            Debug.LogError("Room prefab is missing an EndPoint!");
            return;
        }

        // Move the spawn point to this room's end
        currentSpawnPoint.position = endPoint.position;
        currentSpawnPoint.rotation = endPoint.rotation;
    }
}
