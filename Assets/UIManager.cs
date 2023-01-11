using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public GameObject playerListItemPrefab;
    public Transform playerListContainer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            foreach (var player in PhotonNetwork.PlayerList)
            {
                GameObject playerListItem = Instantiate(playerListItemPrefab, playerListContainer);
                playerListItem.GetComponentInChildren<Text>().text = player.NickName;
            }
    }
}
