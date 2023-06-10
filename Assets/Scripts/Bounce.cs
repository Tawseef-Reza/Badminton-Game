using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    [SerializeField]
    private GameObject border;

    [SerializeField]
    private bool isOpp;

    [SerializeField]
    private Rigidbody rb; // of birdie

    [SerializeField]
    private int extentWidth;

    [SerializeField]
    private int extentHeight;

    [SerializeField]
    private GameObject details;

    private float z;

    [SerializeField]
    private int moveSpeed = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        
    {   //(rb.gameObject.transform.position.y - transform.position.y < 30)
        
        float ydiff = rb.gameObject.transform.position.y - transform.position.y;
        float distNonVertical = Vector2.Distance(new Vector2(rb.gameObject.transform.position.x, rb.gameObject.transform.position.z), new Vector2(transform.position.x, transform.position.z));
        //print(rb.gameObject.transform.position.y - border.transform.position.y);
        //xy pos only
        if (!isOpp && rb.velocity.x > 0 && rb.gameObject.transform.position.x > border.transform.position.x && ydiff < 60) // coming towards left plane
        {
            //moving code currently works for x and z right now, though moving birdie across z is not currently implemented
            float step = moveSpeed * Time.deltaTime;
            Vector2 moveVector = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.z), new Vector2(rb.gameObject.transform.position.x, rb.gameObject.transform.position.z), step);
            float newPosX = moveVector.x;
            float newPosY = moveVector.y;
            transform.position = new Vector3(moveVector.x, transform.position.y, moveVector.y);
            //print("from not opp " + (step));
        }
        else if (isOpp && rb.velocity.x < 0 && rb.gameObject.transform.position.x < border.transform.position.x && ydiff < 60) // coming towards right plane
        {
            //moving code currently works for x and z right now, though moving birdie across z is not currently implemented
            float step = moveSpeed * Time.deltaTime;
            Vector2 moveVector = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.z), new Vector2(rb.gameObject.transform.position.x, rb.gameObject.transform.position.z), step);
            float newPosX = moveVector.x;
            float newPosY = moveVector.y;
            transform.position = new Vector3(moveVector.x, transform.position.y, moveVector.y);
            //print("from opp " + (step));
      

        }
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        float defaultForce = 19.4f; // even game
        float increment = 10;
        // > 60, compensate for forceful shoot
        // < 60, compensate for less forceful shoot
        float distanceFromBorder = Mathf.Abs(rb.gameObject.transform.position.x - border.transform.position.x);
        //print(distanceFromBorder);
        if (isOpp)
            rb.velocity = new Vector3(Random.Range(defaultForce, defaultForce), extentHeight, 0);
        else
            rb.velocity = new Vector3(Random.Range(-defaultForce, -defaultForce), extentHeight, 0);


        //rb.AddForce((Vector3.up * extentHeight) + (Vector3.right * extentWidth));

        //rb.gameObject.transform.rotation = Quaternion.Euler(rb.gameObject.transform.rotation.x, rb.gameObject.transform.rotation.y, 0);
        //rb.gameObject.transform.Rotate(new Vector3(0, 0, 50));

    }
}
