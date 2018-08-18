using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyHUD : MonoBehaviour 
{
  private NetworkManager _networkManager;

  // Use this for initialization
  void Start () 
  {
    _networkManager = GetComponent<NetworkManager>();
  }
  
  // Update is called once per frame
  void Update () 
  {
    
  }

  public void StartHost()
  {
    var client = _networkManager.StartHost();
  }

  void OnStartHost()
  {
    print("Host started");
  }
}
