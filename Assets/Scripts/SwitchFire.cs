using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchFire : MonoBehaviour
{
    ParticleSystem.MainModule mod;
    // Start is called before the first frame update
    void Start()
    {
        mod = GetComponent<ParticleSystem>().main;
        StartCoroutine(VaryFire());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator VaryFire()
    {
        while (true)
        {
            mod.startLifetime = 0.3f;
            mod.startSpeed = 16;
            yield return new WaitForSeconds(2);

            mod.startLifetime = 0.01f;
            mod.startSpeed = 1;
            yield return new WaitForSeconds(3);
            
            
        }
    }
}
