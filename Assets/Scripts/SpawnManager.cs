using Photon.Pun;
using System.IO;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawns; 
    public GameObject Player;

    private void Awake()
    {
        Vector3 randomPosition = spawns[Random.Range(0, spawns.Length)].transform.localPosition;
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", Player.name), randomPosition, Quaternion.identity);
    }
}
