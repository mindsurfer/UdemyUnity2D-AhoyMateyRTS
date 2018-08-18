using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour
{
  public float speedH = 2.0f;
  public float speedV = 2.0f;
  private float yaw = 0.0f;
  private float pitch = 0.0f;

  // Use this for initialization
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (!isLocalPlayer)
      return;

    var horiz = CrossPlatformInputManager.GetAxis("Horizontal");
    var vert = CrossPlatformInputManager.GetAxis("Vertical");

    if (CrossPlatformInputManager.GetButton("Horizontal"))
      transform.Translate(Vector3.right * horiz * 0.1f);
    if (CrossPlatformInputManager.GetButton("Vertical"))
      transform.Translate(Vector3.forward * vert * 0.1f);

    yaw += speedH * Input.GetAxis("Mouse X");
    pitch -= speedV * Input.GetAxis("Mouse Y");

    transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
  }

  public override void OnStartLocalPlayer()
  {
    GetComponentInChildren<Camera>().enabled = true;
    GetComponentInChildren<AudioListener>().enabled = true;
  }
}
