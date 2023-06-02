using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBirdie : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private Transform _transform;
    [SerializeField]
    private Transform _headTransform;

    // Start is called before the first frame update
    void Start()
    {
        rb.centerOfMass = _headTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
