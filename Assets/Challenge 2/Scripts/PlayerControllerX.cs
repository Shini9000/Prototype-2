using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
  public GameObject dogPrefab;
  public float coolDownTimer = 0;
  public float coolDownReady = 3.0f;
  public bool coolDown = true;

  // Update is called once per frame
  void Update()
  {

    if (coolDown is false)
    {
     // Debug.Log("Cooldown false");
      coolDownTimer += Time.deltaTime;
      //Debug.Log(coolDownTimer.ToString());
    }
    else
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        coolDown = false;
      }
    }
    if (coolDownTimer >= coolDownReady)
    {
      coolDownTimer = 0f;
      coolDown = true;
      //Debug.Log(coolDown.ToString());
    }
  }
}