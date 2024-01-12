using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour {

  public Transform objectToTrack;
  public Transform objectToRotate;
  
  float prevYPos;

  void Update() {

    float currentYPos = objectToTrack.position.y;
    
    float yPosDiff = currentYPos - prevYPos;

    Vector3 rotAxis = Vector3.forward;
    objectToRotate.RotateAround(objectToRotate.position, rotAxis, yPosDiff);

    prevYPos = currentYPos;

  }

}
