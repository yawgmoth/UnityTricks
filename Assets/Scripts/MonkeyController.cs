using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyController : MonoBehaviour
{
    public float movespeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<Animator>().SetTrigger("doattack");
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            movespeed += 0.5f*Time.deltaTime;
            GetComponent<Animator>().SetFloat("movespeed", movespeed);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            movespeed -= 0.5f * Time.deltaTime;
            if (movespeed < 0) movespeed = 0;
            GetComponent<Animator>().SetFloat("movespeed", movespeed);
        }

        transform.position += transform.rotation * (new Vector3(0, 0, -movespeed) * Time.deltaTime);

        if (transform.position.x < -4.74)
            transform.position = new Vector3(4.74f, transform.position.y, transform.position.z);
    }
}
