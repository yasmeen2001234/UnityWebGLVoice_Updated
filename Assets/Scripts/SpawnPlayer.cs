using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class SpawnPlayer : MonoBehaviour
{

    public static string playerName;

    public GameObject playerPrefabFemale;

#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    private static extern void ShowMessage(string message);
#endif

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;


    private void Start()
    {
        string MessageToSend = "User is Connected";

        Vector3 randomPosition = new Vector3(Random.Range(0, 1), 0, Random.Range(0, 1));


        PhotonNetwork.Instantiate(playerPrefabFemale.name, randomPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
       


#if UNITY_WEBGL && !UNITY_EDITOR
        ShowMessage(MessageToSend);
#endif

    }


}





