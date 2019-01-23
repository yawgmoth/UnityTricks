using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlParticles : MonoBehaviour
{

    ParticleSystem.MainModule mod;
    // Start is called before the first frame update
    void Start()
    {
        mod = GetComponent<ParticleSystem>().main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") > 0) mod.startLifetime = mod.startLifetime.constant + 0.5f*Time.deltaTime;
        else if (Input.GetAxis("Vertical") < 0 && mod.startLifetime.constant >= 0.1f) mod.startLifetime = mod.startLifetime.constant - 0.5f*Time.deltaTime;

        if (Input.GetAxis("Horizontal") > 0) transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
        else if (Input.GetAxis("Horizontal") < 0) transform.position += new Vector3(-1, 0, 0) * Time.deltaTime;
    }
}
