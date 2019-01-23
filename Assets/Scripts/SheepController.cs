using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : MonoBehaviour
{
    Vector3 target;
    Quaternion targetRotation;
    float starty;

    static List<SheepController> allSheep = new List<SheepController>();

    // Start is called before the first frame update
    void Start()
    {
        allSheep.Add(this);
        starty = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        target = transform.position;
        targetRotation = transform.rotation;
        Vector3 centerOfMass = new Vector3(0, 0, 0);
        foreach (SheepController cont in allSheep)
        {
            if (cont != this)
            {
                Vector3 direction = transform.position - cont.transform.position;
                float distance = direction.sqrMagnitude;
                target += (direction / distance);

                targetRotation = Quaternion.Lerp(cont.transform.rotation, targetRotation, 1 / allSheep.Count);
            }
            centerOfMass += cont.transform.position;
        }

        target = 0.3f * target + 0.7f * centerOfMass;
        target.y = starty;
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 5 * Time.deltaTime)  * transform.rotation;
        transform.position = transform.position + (target - transform.position).normalized * 3 * Time.deltaTime;

    }
}
