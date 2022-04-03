using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour {
    [SerializeField] Transform[] _checkPoints;

    public Transform GetCheckPointAt(int index) => _checkPoints[index];
    public Transform GetCheckPointAtClamped(int index) => _checkPoints[index % _checkPoints.Length];
}
