using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounce : MonoBehaviour
{
    [SerializeField]
    private GameObject border;

    [SerializeField]
    private bool isOpp;

    [SerializeField]
    private Rigidbody rb; // of birdie

    [SerializeField]
    private float extentWidth = 19.4f;

    [SerializeField]
    private float extentHeight = 30f;

    //[SerializeField]
    private float power = 200f;
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
        // > 60, compensate for forceful shoot
        // < 60, compensate for less forceful shoot
        float distanceFromBorder = Mathf.Abs(rb.gameObject.transform.position.x - border.transform.position.x);
        //print(distanceFromBorder);
        print("player bounce ran");
        if (isOpp)
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(Random.Range(extentWidth, extentWidth), extentHeight, 0) * power, ForceMode.Force);
        }
            //rb.velocity = new Vector3(Random.Range(extentWidth, extentWidth), extentHeight, 0);
        else
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(Random.Range(-extentWidth, -extentWidth), extentHeight, 0) * power, ForceMode.Force);

        }
        //rb.velocity = new Vector3(Random.Range(-extentWidth, -extentWidth), extentHeight, 0);


        //rb.AddForce((Vector3.up * extentHeight) + (Vector3.right * extentWidth));

        //rb.gameObject.transform.rotation = Quaternion.Euler(rb.gameObject.transform.rotation.x, rb.gameObject.transform.rotation.y, 0);
        //rb.gameObject.transform.Rotate(new Vector3(0, 0, 50));

    }
}
