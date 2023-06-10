using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppBounce : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private GameObject details;

    [SerializeField]
    private int extent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up * extent / 2 + Vector3.right * extent);
        //rb.gameObject.transform.rotation = Quaternion.Euler(rb.gameObject.transform.rotation.x, rb.gameObject.transform.rotation.y, 0);
        //rb.gameObject.transform.Rotate(new Vector3(0, 0, -50));
    }
}
