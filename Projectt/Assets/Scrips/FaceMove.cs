using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMove : MonoBehaviour
{
    private FaceDector _faceDector;
    [SerializeField] private float _speed = 4f;

    private void Start()
    {
        _faceDector = (FaceDector)FindObjectOfType(typeof(FaceDector));
    }

    private void Update()
    {
        float step = _speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(_faceDector.faceX / 90, 0, 0), step);
    }
}
