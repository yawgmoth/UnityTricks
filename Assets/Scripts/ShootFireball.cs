using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFireball : MonoBehaviour
{
    public Transform fireball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Instantiate(fireball, transform.position + ray.direction * 0.5f, Quaternion.LookRotation(-ray.direction));
        }
    }
}
