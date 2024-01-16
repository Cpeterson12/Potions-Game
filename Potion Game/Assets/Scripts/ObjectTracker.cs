using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour 
{

  public Transform objectToTrack;
  public Transform objectToRotate;

  public float offest = 1.5f;
  public float rotSpeed = 3f;
  float prevYPos;

  void Update() {

    float currentYPos = objectToTrack.position.y - offest;
    
    float yPosDiff = (currentYPos - prevYPos);

    Vector3 rotAxis = Vector3.right;
    objectToRotate.RotateAround(objectToRotate.position, rotAxis, (yPosDiff * rotSpeed));

    prevYPos = currentYPos;

  }

}