using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab1;
    public GameObject playerPrefab2;
    public GameObject playerPrefab3;
    public GameObject playerPrefab4;


    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public void Start()
    {
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        if(PhotonNetwork.PlayerList.Length == 1)
        {
            PhotonNetwork.Instantiate(playerPrefab1.name, randomPosition, Quaternion.identity);
        }
        else if(PhotonNetwork.PlayerList.Length == 2)
        {
            PhotonNetwork.Instantiate(playerPrefab2.name, randomPosition, Quaternion.identity);

        }
        else if (PhotonNetwork.PlayerList.Length == 3)
        {
            PhotonNetwork.Instantiate(playerPrefab3.name, randomPosition, Quaternion.identity);

        }
        else if (PhotonNetwork.PlayerList.Length == 4)
        {
            PhotonNetwork.Instantiate(playerPrefab4.name, randomPosition, Quaternion.identity);

        }
        Debug.Log(PhotonNetwork.NickName);
        foreach (var item in PhotonNetwork.PlayerList)
        {
            Debug.Log(PhotonNetwork.NickName);
        }

    }
}
