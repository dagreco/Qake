using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{  
    private int _playerCount = 1;
    public GameObject SpawnPoint_1;
    public GameObject SpawnPoint_2;

    public void PlayerJoined() //Finds player gameobject and renames to the controlling player
    {
        GameObject newPlayer = GameObject.Find("Player(Clone)");
        newPlayer.name = "Player " + _playerCount;
        SetSpawnPosition(newPlayer);
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
}
