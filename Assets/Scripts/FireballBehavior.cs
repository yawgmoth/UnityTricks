using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, -100));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.rotation * (new Vector3(0, 0, -5) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {   
        Destroy(gameObject);
    }
}
