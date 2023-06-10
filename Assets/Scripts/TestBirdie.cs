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
    private GameObject details;

    [SerializeField]
    private GameObject field;

    [SerializeField]
    private bool airborne = true;
    // Start is called before the first frame update
    void Start()
    {
        //rb.centerOfMass = _headTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (airborne)
        {
            float z = Vector3.Angle(Vector3.up, rb.velocity);
            if (rb.velocity.x < 0)
            {
                details.transform.eulerAngles = new Vector3(0, 0, z);
            }
            else
            {
                details.transform.eulerAngles = new Vector3(0, 0, -z);
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name); 
        if (collision.gameObject.name == "FIELD")
        {
            airborne = false;
        }
    }
    
}
