using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour //Spawns players on specified spawnpoints and gives them names
{  
    //Spawnpoints (In editor always called P1 Spawnpoint and P2 Spawnpoint)
    private GameObject SpawnPoint_1; 
    private GameObject SpawnPoint_2;
    private int RespawnTime = 3;
        
    private int _playerCount = 1;

    private void Awake()
    {
        SpawnPoint_1 = GameObject.Find("P1 Spawnpoint");
        SpawnPoint_2 = GameObject.Find("P2 Spawnpoint");
    }

    public void PlayerJoined() //When player joins, gives him corresponding name (Player 1 and Player 2)
    {
        GameObject lastJoined = GameObject.Find("Character(Clone)");
        lastJoined.name = "Player " + _playerCount;
        SetSpawnPosition(lastJoined);
        _playerCount++;
    }

    private void SetSpawnPosition(GameObject player)
    {
        switch (_playerCount)
        {
            case 1:
                player.transform.position = SpawnPoint_1.transform.position;
                break;
                
            case 2:
                player.transform.position = SpawnPoint_2.transform.position;
                break;

            default:
                break;
        }
    }
    public void BeDead(GameObject player)
    {
        player.SetActive(false);
        StartCoroutine(Respawn(player));



    }
        
    IEnumerator Respawn(GameObject player)
    {
        yield return new WaitForSeconds(RespawnTime);
        switch (player.name)
        {
            case "Player 1":
                player.transform.position = SpawnPoint_1.transform.position;
                break;

            case "Player 2":
                player.transform.position = SpawnPoint_2.transform.position;
                break;

            default:
                break;
        }
        player.SetActive(true);
    }    


}
