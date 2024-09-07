using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
   Rigidbody rb;
    float xInput;
    float zInput;
    public float speed;
    public AudioClip coin;
    public AudioClip enemy;
    public GameObject text;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

    }
    private void FixedUpdate()
    {
       float xVelocity=xInput*speed;
       float zVelocity=zInput*speed;
        rb.velocity=new Vector3 (xVelocity,rb.velocity.y,zVelocity);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().PlayOneShot(coin);
            score.scoreCount+=1;
        }

        if (collision.gameObject.tag =="enemy")
        { 
            Destroy(gameObject);
            text.SetActive(true);
            GetComponent<AudioSource>().PlayOneShot(enemy);
        }

        if (collision.gameObject.tag == "wall")
        {
            rb.AddForce(Vector3.back * 50);
        }


        
    }
    }
