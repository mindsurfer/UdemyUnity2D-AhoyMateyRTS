﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager 
{

  public void MyStartHost()
  {
    Debug.Log(Time.timeSinceLevelLoad + " : Starting Host");
    StartHost();
  }

  public override void OnStartHost()
  {
    Debug.Log(Time.timeSinceLevelLoad + " : Host started");
  }

  public override void OnStartClient(NetworkClient client)
  {
    Debug.Log(Time.timeSinceLevelLoad + " : Client started");
  }

  public override void OnClientConnect(NetworkConnection conn)
  {
    Debug.Log(Time.timeSinceLevelLoad + " : Client connected to " + conn.address);
  }
}
