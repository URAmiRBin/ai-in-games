using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotProductTest : MonoBehaviour
{
    [SerializeField] float _angle;
    [SerializeField] float _distance;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 a = transform.forward;
        Vector3 b = enemy.transform.position - transform.position;

        if(Vector3.Angle(a, b) <= _angle && Vector3.Distance(transform.position, enemy.transform.position) <= _distance)
            Debug.DrawLine(transform.position, enemy.transform.position, Color.red);
    }
}